using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLDataParser : vtkXMLParser
	{
		public enum BigEndian_WrapperEnum
		{
			BigEndian,
			LittleEndian
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLDataParser";

		public new static readonly string MRClassNameKey;

		static vtkXMLDataParser()
		{
			vtkXMLDataParser.MRClassNameKey = "class vtkXMLDataParser";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLDataParser.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLDataParser"));
		}

		public vtkXMLDataParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLDataParser New()
		{
			vtkXMLDataParser result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataParser.vtkXMLDataParser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLDataParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLDataParser() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLDataParser.vtkXMLDataParser_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLDataParser_CharacterDataHandler_01(HandleRef pThis, string data, int length);

		public virtual void CharacterDataHandler(string data, int length)
		{
			vtkXMLDataParser.vtkXMLDataParser_CharacterDataHandler_01(base.GetCppThis(), data, length);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLDataParser_GetAbort_02(HandleRef pThis);

		public virtual int GetAbort()
		{
			return vtkXMLDataParser.vtkXMLDataParser_GetAbort_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLDataParser_GetAttributesEncoding_03(HandleRef pThis);

		public virtual int GetAttributesEncoding()
		{
			return vtkXMLDataParser.vtkXMLDataParser_GetAttributesEncoding_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLDataParser_GetAttributesEncodingMaxValue_04(HandleRef pThis);

		public virtual int GetAttributesEncodingMaxValue()
		{
			return vtkXMLDataParser.vtkXMLDataParser_GetAttributesEncodingMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLDataParser_GetAttributesEncodingMinValue_05(HandleRef pThis);

		public virtual int GetAttributesEncodingMinValue()
		{
			return vtkXMLDataParser.vtkXMLDataParser_GetAttributesEncodingMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataParser_GetCompressor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataCompressor GetCompressor()
		{
			vtkDataCompressor vtkDataCompressor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataParser.vtkXMLDataParser_GetCompressor_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataCompressor = (vtkDataCompressor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataCompressor.Register(null);
				}
			}
			return vtkDataCompressor;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern float vtkXMLDataParser_GetProgress_07(HandleRef pThis);

		public virtual float GetProgress()
		{
			return vtkXMLDataParser.vtkXMLDataParser_GetProgress_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataParser_GetRootElement_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkXMLDataElement GetRootElement()
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataParser.vtkXMLDataParser_GetRootElement_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkXMLDataParser_GetWordTypeSize_09(HandleRef pThis, int wordType);

		public uint GetWordTypeSize(int wordType)
		{
			return vtkXMLDataParser.vtkXMLDataParser_GetWordTypeSize_09(base.GetCppThis(), wordType);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLDataParser_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLDataParser.vtkXMLDataParser_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLDataParser_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLDataParser.vtkXMLDataParser_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataParser_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLDataParser NewInstance()
		{
			vtkXMLDataParser result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataParser.vtkXMLDataParser_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLDataParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLDataParser_Parse_14(HandleRef pThis);

		public override int Parse()
		{
			return vtkXMLDataParser.vtkXMLDataParser_Parse_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkXMLDataParser_ReadAppendedData_15(HandleRef pThis, long offset, IntPtr buffer, long startWord, long numWords, int wordType);

		public long ReadAppendedData(long offset, IntPtr buffer, long startWord, long numWords, int wordType)
		{
			return vtkXMLDataParser.vtkXMLDataParser_ReadAppendedData_15(base.GetCppThis(), offset, buffer, startWord, numWords, wordType);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkXMLDataParser_ReadAppendedData_16(HandleRef pThis, long offset, string buffer, long startWord, long numWords);

		public long ReadAppendedData(long offset, string buffer, long startWord, long numWords)
		{
			return vtkXMLDataParser.vtkXMLDataParser_ReadAppendedData_16(base.GetCppThis(), offset, buffer, startWord, numWords);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkXMLDataParser_ReadAsciiData_17(HandleRef pThis, IntPtr buffer, long startWord, long numWords, int wordType);

		public long ReadAsciiData(IntPtr buffer, long startWord, long numWords, int wordType)
		{
			return vtkXMLDataParser.vtkXMLDataParser_ReadAsciiData_17(base.GetCppThis(), buffer, startWord, numWords, wordType);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkXMLDataParser_ReadBinaryData_18(HandleRef pThis, IntPtr buffer, long startWord, long maxWords, int wordType);

		public long ReadBinaryData(IntPtr buffer, long startWord, long maxWords, int wordType)
		{
			return vtkXMLDataParser.vtkXMLDataParser_ReadBinaryData_18(base.GetCppThis(), buffer, startWord, maxWords, wordType);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkXMLDataParser_ReadInlineData_19(HandleRef pThis, HandleRef element, int isAscii, IntPtr buffer, long startWord, long numWords, int wordType);

		public long ReadInlineData(vtkXMLDataElement element, int isAscii, IntPtr buffer, long startWord, long numWords, int wordType)
		{
			return vtkXMLDataParser.vtkXMLDataParser_ReadInlineData_19(base.GetCppThis(), (element == null) ? default(HandleRef) : element.GetCppThis(), isAscii, buffer, startWord, numWords, wordType);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkXMLDataParser_ReadInlineData_20(HandleRef pThis, HandleRef element, int isAscii, string buffer, long startWord, long numWords);

		public long ReadInlineData(vtkXMLDataElement element, int isAscii, string buffer, long startWord, long numWords)
		{
			return vtkXMLDataParser.vtkXMLDataParser_ReadInlineData_20(base.GetCppThis(), (element == null) ? default(HandleRef) : element.GetCppThis(), isAscii, buffer, startWord, numWords);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataParser_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLDataParser SafeDownCast(vtkObjectBase o)
		{
			vtkXMLDataParser vtkXMLDataParser = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataParser.vtkXMLDataParser_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataParser = (vtkXMLDataParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataParser.Register(null);
				}
			}
			return vtkXMLDataParser;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLDataParser_SetAbort_22(HandleRef pThis, int _arg);

		public virtual void SetAbort(int _arg)
		{
			vtkXMLDataParser.vtkXMLDataParser_SetAbort_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLDataParser_SetAttributesEncoding_23(HandleRef pThis, int _arg);

		public virtual void SetAttributesEncoding(int _arg)
		{
			vtkXMLDataParser.vtkXMLDataParser_SetAttributesEncoding_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLDataParser_SetCompressor_24(HandleRef pThis, HandleRef arg0);

		public virtual void SetCompressor(vtkDataCompressor arg0)
		{
			vtkXMLDataParser.vtkXMLDataParser_SetCompressor_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLDataParser_SetProgress_25(HandleRef pThis, float _arg);

		public virtual void SetProgress(float _arg)
		{
			vtkXMLDataParser.vtkXMLDataParser_SetProgress_25(base.GetCppThis(), _arg);
		}
	}
}
