using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPNrrdReader : vtkMPIImageReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPNrrdReader";

		public new static readonly string MRClassNameKey;

		static vtkPNrrdReader()
		{
			vtkPNrrdReader.MRClassNameKey = "class vtkPNrrdReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPNrrdReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPNrrdReader"));
		}

		public vtkPNrrdReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPNrrdReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPNrrdReader New()
		{
			vtkPNrrdReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPNrrdReader.vtkPNrrdReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPNrrdReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPNrrdReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPNrrdReader.vtkPNrrdReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPNrrdReader_CanReadFile_01(HandleRef pThis, string filename);

		public override int CanReadFile(string filename)
		{
			return vtkPNrrdReader.vtkPNrrdReader_CanReadFile_01(base.GetCppThis(), filename);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPNrrdReader_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPNrrdReader.vtkPNrrdReader_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPNrrdReader_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPNrrdReader.vtkPNrrdReader_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPNrrdReader_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPNrrdReader NewInstance()
		{
			vtkPNrrdReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPNrrdReader.vtkPNrrdReader_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPNrrdReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPNrrdReader_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPNrrdReader SafeDownCast(vtkObjectBase o)
		{
			vtkPNrrdReader vtkPNrrdReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPNrrdReader.vtkPNrrdReader_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPNrrdReader = (vtkPNrrdReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPNrrdReader.Register(null);
				}
			}
			return vtkPNrrdReader;
		}
	}
}
