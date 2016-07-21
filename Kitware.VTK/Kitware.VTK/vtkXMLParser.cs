using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLParser : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLParser";

		public new static readonly string MRClassNameKey;

		static vtkXMLParser()
		{
			vtkXMLParser.MRClassNameKey = "class vtkXMLParser";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLParser.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLParser"));
		}

		public vtkXMLParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLParser New()
		{
			vtkXMLParser result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLParser.vtkXMLParser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLParser() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLParser.vtkXMLParser_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLParser_CleanupParser_01(HandleRef pThis);

		public virtual int CleanupParser()
		{
			return vtkXMLParser.vtkXMLParser_CleanupParser_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLParser_GetEncoding_02(HandleRef pThis);

		public virtual string GetEncoding()
		{
			return Marshal.PtrToStringAnsi(vtkXMLParser.vtkXMLParser_GetEncoding_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLParser_GetFileName_03(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkXMLParser.vtkXMLParser_GetFileName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLParser_GetIgnoreCharacterData_04(HandleRef pThis);

		public virtual int GetIgnoreCharacterData()
		{
			return vtkXMLParser.vtkXMLParser_GetIgnoreCharacterData_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLParser_InitializeParser_05(HandleRef pThis);

		public virtual int InitializeParser()
		{
			return vtkXMLParser.vtkXMLParser_InitializeParser_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLParser_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLParser.vtkXMLParser_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLParser_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLParser.vtkXMLParser_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLParser_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLParser NewInstance()
		{
			vtkXMLParser result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLParser.vtkXMLParser_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLParser_Parse_10(HandleRef pThis);

		public virtual int Parse()
		{
			return vtkXMLParser.vtkXMLParser_Parse_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLParser_Parse_11(HandleRef pThis, string inputString);

		public virtual int Parse(string inputString)
		{
			return vtkXMLParser.vtkXMLParser_Parse_11(base.GetCppThis(), inputString);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLParser_Parse_12(HandleRef pThis, string inputString, uint length);

		public virtual int Parse(string inputString, uint length)
		{
			return vtkXMLParser.vtkXMLParser_Parse_12(base.GetCppThis(), inputString, length);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLParser_ParseChunk_13(HandleRef pThis, string inputString, uint length);

		public virtual int ParseChunk(string inputString, uint length)
		{
			return vtkXMLParser.vtkXMLParser_ParseChunk_13(base.GetCppThis(), inputString, length);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLParser_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLParser SafeDownCast(vtkObjectBase o)
		{
			vtkXMLParser vtkXMLParser = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLParser.vtkXMLParser_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLParser = (vtkXMLParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLParser.Register(null);
				}
			}
			return vtkXMLParser;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLParser_SeekG_15(HandleRef pThis, int position);

		public void SeekG(int position)
		{
			vtkXMLParser.vtkXMLParser_SeekG_15(base.GetCppThis(), position);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLParser_SetEncoding_16(HandleRef pThis, string _arg);

		public virtual void SetEncoding(string _arg)
		{
			vtkXMLParser.vtkXMLParser_SetEncoding_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLParser_SetFileName_17(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkXMLParser.vtkXMLParser_SetFileName_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLParser_SetIgnoreCharacterData_18(HandleRef pThis, int _arg);

		public virtual void SetIgnoreCharacterData(int _arg)
		{
			vtkXMLParser.vtkXMLParser_SetIgnoreCharacterData_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLParser_TellG_19(HandleRef pThis);

		public int TellG()
		{
			return vtkXMLParser.vtkXMLParser_TellG_19(base.GetCppThis());
		}
	}
}
