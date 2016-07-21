using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPDataSetReader : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPDataSetReader";

		public new static readonly string MRClassNameKey;

		static vtkPDataSetReader()
		{
			vtkPDataSetReader.MRClassNameKey = "class vtkPDataSetReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPDataSetReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPDataSetReader"));
		}

		public vtkPDataSetReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPDataSetReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPDataSetReader New()
		{
			vtkPDataSetReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPDataSetReader.vtkPDataSetReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDataSetReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPDataSetReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPDataSetReader.vtkPDataSetReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPDataSetReader_CanReadFile_01(HandleRef pThis, string filename);

		public int CanReadFile(string filename)
		{
			return vtkPDataSetReader.vtkPDataSetReader_CanReadFile_01(base.GetCppThis(), filename);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPDataSetReader_GetDataType_02(HandleRef pThis);

		public virtual int GetDataType()
		{
			return vtkPDataSetReader.vtkPDataSetReader_GetDataType_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPDataSetReader_GetFileName_03(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkPDataSetReader.vtkPDataSetReader_GetFileName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPDataSetReader_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPDataSetReader.vtkPDataSetReader_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPDataSetReader_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPDataSetReader.vtkPDataSetReader_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPDataSetReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPDataSetReader NewInstance()
		{
			vtkPDataSetReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPDataSetReader.vtkPDataSetReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDataSetReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPDataSetReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPDataSetReader SafeDownCast(vtkObjectBase o)
		{
			vtkPDataSetReader vtkPDataSetReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPDataSetReader.vtkPDataSetReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPDataSetReader = (vtkPDataSetReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPDataSetReader.Register(null);
				}
			}
			return vtkPDataSetReader;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPDataSetReader_SetFileName_09(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkPDataSetReader.vtkPDataSetReader_SetFileName_09(base.GetCppThis(), _arg);
		}
	}
}
