using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageReader : vtkImageReader2
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageReader";

		public new static readonly string MRClassNameKey;

		static vtkImageReader()
		{
			vtkImageReader.MRClassNameKey = "class vtkImageReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageReader"));
		}

		public vtkImageReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageReader New()
		{
			vtkImageReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReader.vtkImageReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageReader.vtkImageReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader_ComputeInverseTransformedExtent_01(HandleRef pThis, IntPtr inExtent, IntPtr outExtent);

		public void ComputeInverseTransformedExtent(IntPtr inExtent, IntPtr outExtent)
		{
			vtkImageReader.vtkImageReader_ComputeInverseTransformedExtent_01(base.GetCppThis(), inExtent, outExtent);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader_ComputeInverseTransformedIncrements_02(HandleRef pThis, IntPtr inIncr, IntPtr outIncr);

		public void ComputeInverseTransformedIncrements(IntPtr inIncr, IntPtr outIncr)
		{
			vtkImageReader.vtkImageReader_ComputeInverseTransformedIncrements_02(base.GetCppThis(), inIncr, outIncr);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern ulong vtkImageReader_GetDataMask_03(HandleRef pThis);

		public virtual ulong GetDataMask()
		{
			return vtkImageReader.vtkImageReader_GetDataMask_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader_GetDataVOI_04(HandleRef pThis);

		public virtual int[] GetDataVOI()
		{
			IntPtr intPtr = vtkImageReader.vtkImageReader_GetDataVOI_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader_GetDataVOI_05(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetDataVOI(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageReader.vtkImageReader_GetDataVOI_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader_GetDataVOI_06(HandleRef pThis, IntPtr _arg);

		public virtual void GetDataVOI(IntPtr _arg)
		{
			vtkImageReader.vtkImageReader_GetDataVOI_06(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader_GetScalarArrayName_07(HandleRef pThis);

		public virtual string GetScalarArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkImageReader.vtkImageReader_GetScalarArrayName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader_GetTransform_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTransform GetTransform()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReader.vtkImageReader_GetTransform_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageReader.vtkImageReader_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageReader.vtkImageReader_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageReader NewInstance()
		{
			vtkImageReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReader.vtkImageReader_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader_OpenAndSeekFile_13(HandleRef pThis, IntPtr extent, int slice);

		public int OpenAndSeekFile(IntPtr extent, int slice)
		{
			return vtkImageReader.vtkImageReader_OpenAndSeekFile_13(base.GetCppThis(), extent, slice);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageReader SafeDownCast(vtkObjectBase o)
		{
			vtkImageReader vtkImageReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReader.vtkImageReader_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageReader = (vtkImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageReader.Register(null);
				}
			}
			return vtkImageReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader_SetDataMask_15(HandleRef pThis, ulong _arg);

		public virtual void SetDataMask(ulong _arg)
		{
			vtkImageReader.vtkImageReader_SetDataMask_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader_SetDataVOI_16(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetDataVOI(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkImageReader.vtkImageReader_SetDataVOI_16(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader_SetDataVOI_17(HandleRef pThis, IntPtr _arg);

		public virtual void SetDataVOI(IntPtr _arg)
		{
			vtkImageReader.vtkImageReader_SetDataVOI_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader_SetScalarArrayName_18(HandleRef pThis, string _arg);

		public virtual void SetScalarArrayName(string _arg)
		{
			vtkImageReader.vtkImageReader_SetScalarArrayName_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader_SetTransform_19(HandleRef pThis, HandleRef arg0);

		public virtual void SetTransform(vtkTransform arg0)
		{
			vtkImageReader.vtkImageReader_SetTransform_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
