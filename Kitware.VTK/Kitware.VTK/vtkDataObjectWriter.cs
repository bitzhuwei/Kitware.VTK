using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataObjectWriter : vtkWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectWriter";

		public new static readonly string MRClassNameKey;

		static vtkDataObjectWriter()
		{
			vtkDataObjectWriter.MRClassNameKey = "class vtkDataObjectWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObjectWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectWriter"));
		}

		public vtkDataObjectWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataObjectWriter New()
		{
			vtkDataObjectWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectWriter.vtkDataObjectWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataObjectWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataObjectWriter.vtkDataObjectWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectWriter_GetFieldDataName_01(HandleRef pThis);

		public string GetFieldDataName()
		{
			return Marshal.PtrToStringAnsi(vtkDataObjectWriter.vtkDataObjectWriter_GetFieldDataName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectWriter_GetFileName_02(HandleRef pThis);

		public string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkDataObjectWriter.vtkDataObjectWriter_GetFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataObjectWriter_GetFileType_03(HandleRef pThis);

		public int GetFileType()
		{
			return vtkDataObjectWriter.vtkDataObjectWriter_GetFileType_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectWriter_GetHeader_04(HandleRef pThis);

		public string GetHeader()
		{
			return Marshal.PtrToStringAnsi(vtkDataObjectWriter.vtkDataObjectWriter_GetHeader_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataObjectWriter_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataObjectWriter.vtkDataObjectWriter_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataObjectWriter_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataObjectWriter.vtkDataObjectWriter_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataObjectWriter NewInstance()
		{
			vtkDataObjectWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectWriter.vtkDataObjectWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataObjectWriter SafeDownCast(vtkObjectBase o)
		{
			vtkDataObjectWriter vtkDataObjectWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectWriter.vtkDataObjectWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectWriter = (vtkDataObjectWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectWriter.Register(null);
				}
			}
			return vtkDataObjectWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataObjectWriter_SetFieldDataName_10(HandleRef pThis, string fieldname);

		public void SetFieldDataName(string fieldname)
		{
			vtkDataObjectWriter.vtkDataObjectWriter_SetFieldDataName_10(base.GetCppThis(), fieldname);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataObjectWriter_SetFileName_11(HandleRef pThis, string filename);

		public void SetFileName(string filename)
		{
			vtkDataObjectWriter.vtkDataObjectWriter_SetFileName_11(base.GetCppThis(), filename);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataObjectWriter_SetFileType_12(HandleRef pThis, int type);

		public void SetFileType(int type)
		{
			vtkDataObjectWriter.vtkDataObjectWriter_SetFileType_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataObjectWriter_SetFileTypeToASCII_13(HandleRef pThis);

		public void SetFileTypeToASCII()
		{
			vtkDataObjectWriter.vtkDataObjectWriter_SetFileTypeToASCII_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataObjectWriter_SetFileTypeToBinary_14(HandleRef pThis);

		public void SetFileTypeToBinary()
		{
			vtkDataObjectWriter.vtkDataObjectWriter_SetFileTypeToBinary_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataObjectWriter_SetHeader_15(HandleRef pThis, string header);

		public void SetHeader(string header)
		{
			vtkDataObjectWriter.vtkDataObjectWriter_SetHeader_15(base.GetCppThis(), header);
		}
	}
}
