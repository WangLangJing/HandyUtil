using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace FileSpliter
{
     public class Spliter
     {
         public enum SpliteMode
         {
             /// <summary>
             /// 按数量
             /// </summary>
           Number=0x0000,
             /// <summary>
             /// 按大小
             /// </summary>
           Size=0x0001
         }
         /// <summary>
         /// 开始分割
         /// </summary>
         public event EventHandler StartSplite = null;
         /// <summary>
         /// 开始合并
         /// </summary>
         public event EventHandler StartCombine = null;
         /// <summary>
         /// 分割完成后的事件
         /// </summary>
         public event EventHandler Splited = null;
         /// <summary>
         /// 合并完成后的事件
         /// </summary>
         public event EventHandler Combined = null;
         /// <summary>
         /// 异常发生事件
         /// </summary>
         public event EventHandler AbNormalHappend = null;
         /// <summary>
         /// 分割进度事件
         /// </summary>
         public event EventHandler SpliteProgressing = null;
         /// <summary>
         /// 合并进度事件
         /// </summary>
         public event EventHandler CombineProgressing = null;
         private static Int32 MaxReadSize = 1024 * 100;
       #region 分割文件
            /// <summary>
            /// 分割文件
            /// </summary>
            /// <param name="strFlag">分割单位</param>
            /// <param name="intFlag">分割大小或者数量，其含义取决于分割的模式</param>
            /// <param name="strPath">分割后的文件存放路径</param>
            /// <param name="strFile">要分割的文件</param>
            /// <param name="PBar">进度条显示</param>
          /// <param name="spliteMode">分割文件的模式</param>
          public void SplitFile(String strPath,String strFile, ProgressBar PBar,SpliteMode spliteMode,Int32 intFlag=0,String strFlag=null)
          {
              if (PBar != null)
                  PBar.Value = 0;
              if (this.StartSplite != null)
              {
                  this.StartSplite.Invoke(
                      "\r\n开始新的分割任务" + "\r\n被分割的文件路径及名称:" + strFile + "\r\n任务开始时间:" + DateTime.Now.ToString(),
                      null);
              }
              FileStream SplitFileStream = null;
              BinaryReader SplitFileReader = null;
              try
              {
                  //以文件的全路径对应的字符串和文件打开模式来初始化FileStream文件流实例
                  SplitFileStream = new FileStream(strFile, FileMode.Open);
                  //以FileStream文件流来初始化BinaryReader文件阅读器
                  SplitFileReader = new BinaryReader(SplitFileStream);
                  int iFileSize = 0;
                  Int32 iFileCount = 0;
                  switch (spliteMode)
                  {
                      case SpliteMode.Size:
                          {
                              //根据选择来设定分割的小文件的大小
                              switch (strFlag)
                              {
                                  case "Byte":
                                      iFileSize = intFlag;
                                      break;
                                  case "KB":
                                      iFileSize = intFlag * 1024;
                                      break;
                                  case "MB":
                                      iFileSize = intFlag * 1024 * 1024;
                                      break;
                                  case "GB":
                                      iFileSize = intFlag * 1024 * 1024 * 1024;
                                      break;
                                  default: break;
                              }
                              iFileCount =(Int32)(SplitFileStream.Length / iFileSize);
                              if (SplitFileStream.Length % iFileSize != 0) ++iFileCount;
                          } break;
                      case SpliteMode.Number:
                          {
                              iFileCount = intFlag;
                              iFileSize = (Int32)(SplitFileStream.Length / iFileCount);
                          }
                          break;
                      default: break;
                  }
                  Byte[] TempBytes;
                  String[] TempExtra = strFile.Split('.');
                  String[] TempExtraFileName = TempExtra[0].Split('\\');
                  String SumFileName = TempExtraFileName[TempExtraFileName.Length - 1];
                  Int32 readerCount = 0;
                  for (int i = 1; i <= iFileCount; ++i)
                  {
                      if (this.SpliteProgressing != null)
                      {
                          this.SpliteProgressing.BeginInvoke("正在分割出第"+i+"个文件("+i+"/"+iFileCount+")",null,null,null);
                      }
                      if (PBar != null)
                           PBar.Value=0;
                      readerCount = 0;
                      //确定小文件的文件名称
                      String sTempFileName = strPath + @"\" + SumFileName + i.ToString().PadLeft(4, '0') + "." + TempExtra[TempExtra.Length - 1]; //小文件名
                      FileStream TempStream = new FileStream(sTempFileName, FileMode.OpenOrCreate);
                      BinaryWriter TempWriter = new BinaryWriter(TempStream);
                      readerCount = (Int32)iFileSize / MaxReadSize;
                      if (iFileSize % MaxReadSize != 0) ++readerCount;
                      if (PBar != null)
                          PBar.Maximum = readerCount;
                      for (int j = 0; j < readerCount; ++j)
                      {
                          TempBytes = SplitFileReader.ReadBytes(MaxReadSize);
                          TempWriter.Write(TempBytes);
                          TempBytes = null;
                          if (PBar != null)
                              ++PBar.Value;
                      }
                      TempWriter.Close();
                      TempStream.Close();          
                  }
                  if (this.Splited != null)
                  {
                      if (this.SpliteProgressing != null)
                      {
                          this.SpliteProgressing.BeginInvoke("分割完成", null, null, null);
                      }
                      this.Splited.Invoke(
                          "\r\n分割完成" + "\r\n被分割的文件路径及名称:" + strFile + "\r\n分割后文件存储路径:" + strPath + "\r\n任务完成时间:" + DateTime.Now.ToString(),
                      null);
                  }
              }
              catch (Exception exp)
              {
                  if (this.AbNormalHappend != null)
                  {
                      this.AbNormalHappend.Invoke(
      "\r\n异常的分割任务" + "\r\n被分割的文件路径及名称:" + strFile + "\r\n异常原因:" + exp .Message+ "\r\n任务异常发生时间:" + DateTime.Now.ToString(),
       null);
                  }
                  return;
              }
              finally
              {
                  if (SplitFileReader!=null)
                      SplitFileReader.Close();
                  if (SplitFileStream!=null)
                     SplitFileStream.Close();
              }
        }
      #endregion
          #region 合并文件
          /// <summary>
          /// 合并文件
          /// </summary>
          /// <param name="list">要合并的文件集合</param>
          /// <param name="strPath">合并后的文件名称</param>
          /// <param name="PBar">进度条显示</param>
          public void CombineFile(String[] strFile, String strPath, ProgressBar PBar)
          {
              if (PBar != null)
                  PBar.Value = 0;
              if (this.StartCombine != null)
              {
                  this.StartCombine.Invoke(
                      "\r\n开始新的合并任务" + "\r\n合并目标文件路径及名称:" + strPath + "\r\n任务开始时间:" + DateTime.Now.ToString(),
                      null);
              }
              FileStream AddStream = null;
              BinaryWriter AddWriter = null;
              try
              {
              
                  AddStream = new FileStream(strPath, FileMode.Append);
                  AddWriter = new BinaryWriter(AddStream);
                  FileStream TempStream = null;
                  BinaryReader TempReader = null;
                  Int32 readerCount = 0;
                  if (PBar != null)
                      PBar.Maximum=0;
                  for (int i = 0; i < strFile.Length; ++i)
                  {
                      if (PBar != null)
                          PBar.Value=0;
                      if (this.CombineProgressing != null)
                      {
                          this.CombineProgressing.BeginInvoke("正在合并第" + (i + 1) + "个文件("+(i+1)+"/"+strFile.Length+"):" + strFile[i].ToString(),null,null,null);
                      }
                      readerCount = 0;
                      TempStream = new FileStream(strFile[i].ToString(), FileMode.Open);
                      TempReader = new BinaryReader(TempStream);
                      readerCount = (Int32)Math.Ceiling((Double)TempStream.Length / MaxReadSize);
                      if (PBar != null)
                          PBar.Maximum=readerCount;
                      for (int j = 0; j < readerCount; ++j)
                      {
                          AddWriter.Write(TempReader.ReadBytes(MaxReadSize));
                          if (PBar != null)
                              ++PBar.Value;
                      }
                      TempReader.Close();
                      TempStream.Close();
                  }

                  if (this.Combined != null)
                  {
                      if (this.CombineProgressing != null)
                      {
                          this.CombineProgressing.BeginInvoke("合并完成", null, null, null);
                      }
                      this.Combined.Invoke(
                          "\r\n完成合并" + "\r\n合并目标文件路径及名称:" + strPath + "\r\n任务完成时间:" + DateTime.Now.ToString(),
                      null);
                  }
              }
              catch (Exception exp)
              {
                  if (this.AbNormalHappend != null)
                  {
                      this.AbNormalHappend.Invoke(
      "\r\n异常的合并任务" + "\r\n合并目标文件路径及名称:" + strPath + "\r\n异常原因:" + exp.Message + "\r\n任务异常发生时间:" + DateTime.Now.ToString(),
       null);
                  }
                  return;
              }
              finally
              {
                  if(AddWriter!=null)
                     AddWriter.Close();
                  if(AddStream!=null)
                    AddStream.Close();
              }
          }
          #endregion
     }
     
}
