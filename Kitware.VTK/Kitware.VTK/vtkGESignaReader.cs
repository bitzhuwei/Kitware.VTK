using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGESignaReader : vtkMedicalImageReader2
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGESignaReader";

		public new static readonly string MRClassNameKey;

		static vtkGESignaReader()
		{
			vtkGESignaReader.MRClassNameKey = "class vtkGESignaReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGESignaReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGESignaReader"));
		}

		public vtkGESignaReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGESignaReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGESignaReader New()
		{
			vtkGESignaReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGESignaReader.vtkGESignaReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGESignaReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGESignaReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGESignaReader.vtkGESignaReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGESignaReader_CanReadFile_01(HandleRef pThis, string fname);

		public override int CanReadFile(string fname)
		{
			return vtkGESignaReader.vtkGESignaReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGESignaReader_GetDescriptiveName_02(HandleRef pThis);

		public override string GetDescriptiveName()
		{
			return Marshal.PtrToStringAnsi(vtkGESignaReader.vtkGESignaReader_GetDescriptiveName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGESignaReader_GetFileExtensions_03(HandleRef pThis);

		public override string GetFileExtensions()
		{
			return Marshal.PtrToStringAnsi(vtkGESignaReader.vtkGESignaReader_GetFileExtensions_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGESignaReader_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGESignaReader.vtkGESignaReader_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGESignaReader_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGESignaReader.vtkGESignaReader_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGESignaReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGESignaReader NewInstance()
		{
			vtkGESignaReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGESignaReader.vtkGESignaReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGESignaReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGESignaReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGESignaReader SafeDownCast(vtkObjectBase o)
		{
			vtkGESignaReader vtkGESignaReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGESignaReader.vtkGESignaReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGESignaReader = (vtkGESignaReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGESignaReader.Register(null);
				}
			}
			return vtkGESignaReader;
		}
	}
}
