/*
 * Author: Jiulin Hu
 * Mail: tohujiulin@126.com
 * Description: Convert word to HTMLs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Office.Core;

namespace ConvertWordToHTML
{
    public class WordOperation
    {
        #region Parameters
        private object _oFileName;
        private Object _readonlyObj = false;
        private Object _wdNotSaveObj = WdSaveOptions.wdDoNotSaveChanges;
        //If set repair, program will crash easiliy.
        private Object _openAndRepairObj = true;
        private Microsoft.Office.Interop.Word._Document _Document = null;
        private object _oMissing = System.Reflection.Missing.Value;
        private Microsoft.Office.Interop.Word.Application _WordInstance = null;
        #endregion

        #region Constructor and destructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fileName"></param>
        public WordOperation(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new Exception("Can not find doc file " + fileName);
            }
            _oFileName = fileName;
            if (null == _WordInstance)
            {
                _WordInstance = new Microsoft.Office.Interop.Word.Application();
                _WordInstance.Visible = false;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
            }
            try
            {
                _Document = _WordInstance.Documents.Open(ref _oFileName,
                ref _oMissing, ref _readonlyObj, ref _oMissing, ref _oMissing, ref _oMissing,
                ref _oMissing, ref _oMissing, ref _oMissing, ref _oMissing, ref _oMissing,
                ref _oMissing, ref _oMissing, ref _oMissing, ref _oMissing, ref _oMissing);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~WordOperation()
        {
            Release();
        }

        /// <summary>
        /// Relase doc
        /// </summary>
        public void ReleaseDoc()
        {
            try
            {
                if (null != _Document)
                {
                    _Document.Close(ref _wdNotSaveObj, ref _oMissing, ref _oMissing);
                    _Document = null;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Failed to release doc: " + ex.Message);
            }
        }

        /// <summary>
        /// Release word
        /// </summary>
        public void Release()
        {
            try
            {
                if (null != _Document)
                {
                    _Document.Close(ref _wdNotSaveObj, ref _oMissing, ref _oMissing);
                    _Document = null;
                }

                if (null != _WordInstance)
                {
                    _WordInstance.Quit(ref _wdNotSaveObj, ref _oMissing, ref _oMissing);
                    _WordInstance = null;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Convert Method: doc to html
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSaveFileName"></param>
        /// <returns></returns>
        public bool WordToHtml(string strSaveFileName)
        { 
            Type docType = _Document.GetType();
            object saveFileName = strSaveFileName;
            try
            {
                // Save format: wdFormatFilterHTML to avoid VML
                docType.InvokeMember("SaveAs", System.Reflection.BindingFlags.InvokeMethod, null, _Document,
                                     new object[] { saveFileName, Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatFilteredHTML }
                                     );
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
         }
        #endregion
    }
}
