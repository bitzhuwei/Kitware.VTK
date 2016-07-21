using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkJPEGReader : vtkImageReader2
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkJPEGReader";

		public new static readonly string MRClassNameKey;

		static vtkJPEGReader()
		{
			vtkJPEGReader.MRClassNameKey = "class vtkJPEGReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkJPEGReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkJPEGReader"));
		}

		public vtkJPEGReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkJPEGReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkJPEGReader New()
		{
			vtkJPEGReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkJPEGReader.vtkJPEGReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJPEGReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkJPEGReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkJPEGReader.vtkJPEGReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkJPEGReader_CanReadFile_01(HandleRef pThis, string fname);

		public override int CanReadFile(string fname)
		{
			return vtkJPEGReader.vtkJPEGReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkJPEGReader_GetDescriptiveName_02(HandleRef pThis);

		public override string GetDescriptiveName()
		{
			return Marshal.PtrToStringAnsi(vtkJPEGReader.vtkJPEGReader_GetDescriptiveName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkJPEGReader_GetFileExtensions_03(HandleRef pThis);

		public override string GetFileExtensions()
		{
			return Marshal.PtrToStringAnsi(vtkJPEGReader.vtkJPEGReader_GetFileExtensions_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkJPEGReader_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkJPEGReader.vtkJPEGReader_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkJPEGReader_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkJPEGReader.vtkJPEGReader_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkJPEGReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkJPEGReader NewInstance()
		{
			vtkJPEGReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkJPEGReader.vtkJPEGReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJPEGReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkJPEGReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkJPEGReader SafeDownCast(vtkObjectBase o)
		{
			vtkJPEGReader vtkJPEGReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkJPEGReader.vtkJPEGReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkJPEGReader = (vtkJPEGReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkJPEGReader.Register(null);
				}
			}
			return vtkJPEGReader;
		}
	}
}
