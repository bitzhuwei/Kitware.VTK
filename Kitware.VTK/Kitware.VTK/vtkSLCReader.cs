using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSLCReader : vtkImageReader2
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSLCReader";

		public new static readonly string MRClassNameKey;

		static vtkSLCReader()
		{
			vtkSLCReader.MRClassNameKey = "class vtkSLCReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSLCReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSLCReader"));
		}

		public vtkSLCReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLCReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSLCReader New()
		{
			vtkSLCReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSLCReader.vtkSLCReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSLCReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSLCReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSLCReader.vtkSLCReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSLCReader_CanReadFile_01(HandleRef pThis, string fname);

		public override int CanReadFile(string fname)
		{
			return vtkSLCReader.vtkSLCReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLCReader_GetDescriptiveName_02(HandleRef pThis);

		public override string GetDescriptiveName()
		{
			return Marshal.PtrToStringAnsi(vtkSLCReader.vtkSLCReader_GetDescriptiveName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSLCReader_GetError_03(HandleRef pThis);

		public virtual int GetError()
		{
			return vtkSLCReader.vtkSLCReader_GetError_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLCReader_GetFileExtensions_04(HandleRef pThis);

		public override string GetFileExtensions()
		{
			return Marshal.PtrToStringAnsi(vtkSLCReader.vtkSLCReader_GetFileExtensions_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLCReader_GetFileName_05(HandleRef pThis);

		public override string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkSLCReader.vtkSLCReader_GetFileName_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSLCReader_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSLCReader.vtkSLCReader_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSLCReader_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSLCReader.vtkSLCReader_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLCReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSLCReader NewInstance()
		{
			vtkSLCReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSLCReader.vtkSLCReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSLCReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLCReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSLCReader SafeDownCast(vtkObjectBase o)
		{
			vtkSLCReader vtkSLCReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSLCReader.vtkSLCReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSLCReader = (vtkSLCReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSLCReader.Register(null);
				}
			}
			return vtkSLCReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSLCReader_SetFileName_11(HandleRef pThis, string _arg);

		public override void SetFileName(string _arg)
		{
			vtkSLCReader.vtkSLCReader_SetFileName_11(base.GetCppThis(), _arg);
		}
	}
}
