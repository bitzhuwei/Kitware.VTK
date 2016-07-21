using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVPICReader : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVPICReader";

		public new static readonly string MRClassNameKey;

		static vtkVPICReader()
		{
			vtkVPICReader.MRClassNameKey = "class vtkVPICReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVPICReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVPICReader"));
		}

		public vtkVPICReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkVPICReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVPICReader New()
		{
			vtkVPICReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVPICReader.vtkVPICReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVPICReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVPICReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVPICReader.vtkVPICReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_DisableAllPointArrays_01(HandleRef pThis);

		public void DisableAllPointArrays()
		{
			vtkVPICReader.vtkVPICReader_DisableAllPointArrays_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_EnableAllPointArrays_02(HandleRef pThis);

		public void EnableAllPointArrays()
		{
			vtkVPICReader.vtkVPICReader_EnableAllPointArrays_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkVPICReader_GetFileName_03(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkVPICReader.vtkVPICReader_GetFileName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkVPICReader_GetNumberOfPointArrays_04(HandleRef pThis);

		public int GetNumberOfPointArrays()
		{
			return vtkVPICReader.vtkVPICReader_GetNumberOfPointArrays_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkVPICReader_GetOutput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageData GetOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVPICReader.vtkVPICReader_GetOutput_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkVPICReader_GetOutput_06(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageData GetOutput(int index)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVPICReader.vtkVPICReader_GetOutput_06(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkVPICReader_GetPointArrayName_07(HandleRef pThis, int index);

		public string GetPointArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkVPICReader.vtkVPICReader_GetPointArrayName_07(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkVPICReader_GetPointArrayStatus_08(HandleRef pThis, string name);

		public int GetPointArrayStatus(string name)
		{
			return vtkVPICReader.vtkVPICReader_GetPointArrayStatus_08(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkVPICReader_GetStride_09(HandleRef pThis);

		public virtual int[] GetStride()
		{
			IntPtr intPtr = vtkVPICReader.vtkVPICReader_GetStride_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_GetStride_10(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetStride(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkVPICReader.vtkVPICReader_GetStride_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_GetStride_11(HandleRef pThis, IntPtr _arg);

		public virtual void GetStride(IntPtr _arg)
		{
			vtkVPICReader.vtkVPICReader_GetStride_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkVPICReader_GetXLayout_12(HandleRef pThis);

		public virtual int[] GetXLayout()
		{
			IntPtr intPtr = vtkVPICReader.vtkVPICReader_GetXLayout_12(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_GetXLayout_13(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetXLayout(ref int _arg1, ref int _arg2)
		{
			vtkVPICReader.vtkVPICReader_GetXLayout_13(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_GetXLayout_14(HandleRef pThis, IntPtr _arg);

		public virtual void GetXLayout(IntPtr _arg)
		{
			vtkVPICReader.vtkVPICReader_GetXLayout_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkVPICReader_GetYLayout_15(HandleRef pThis);

		public virtual int[] GetYLayout()
		{
			IntPtr intPtr = vtkVPICReader.vtkVPICReader_GetYLayout_15(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_GetYLayout_16(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetYLayout(ref int _arg1, ref int _arg2)
		{
			vtkVPICReader.vtkVPICReader_GetYLayout_16(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_GetYLayout_17(HandleRef pThis, IntPtr _arg);

		public virtual void GetYLayout(IntPtr _arg)
		{
			vtkVPICReader.vtkVPICReader_GetYLayout_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkVPICReader_GetZLayout_18(HandleRef pThis);

		public virtual int[] GetZLayout()
		{
			IntPtr intPtr = vtkVPICReader.vtkVPICReader_GetZLayout_18(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_GetZLayout_19(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetZLayout(ref int _arg1, ref int _arg2)
		{
			vtkVPICReader.vtkVPICReader_GetZLayout_19(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_GetZLayout_20(HandleRef pThis, IntPtr _arg);

		public virtual void GetZLayout(IntPtr _arg)
		{
			vtkVPICReader.vtkVPICReader_GetZLayout_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkVPICReader_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVPICReader.vtkVPICReader_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkVPICReader_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVPICReader.vtkVPICReader_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkVPICReader_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVPICReader NewInstance()
		{
			vtkVPICReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVPICReader.vtkVPICReader_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVPICReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkVPICReader_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVPICReader SafeDownCast(vtkObjectBase o)
		{
			vtkVPICReader vtkVPICReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVPICReader.vtkVPICReader_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVPICReader = (vtkVPICReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVPICReader.Register(null);
				}
			}
			return vtkVPICReader;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_SetFileName_26(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkVPICReader.vtkVPICReader_SetFileName_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_SetPointArrayStatus_27(HandleRef pThis, string name, int status);

		public void SetPointArrayStatus(string name, int status)
		{
			vtkVPICReader.vtkVPICReader_SetPointArrayStatus_27(base.GetCppThis(), name, status);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_SetStride_28(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetStride(int _arg1, int _arg2, int _arg3)
		{
			vtkVPICReader.vtkVPICReader_SetStride_28(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_SetStride_29(HandleRef pThis, IntPtr _arg);

		public virtual void SetStride(IntPtr _arg)
		{
			vtkVPICReader.vtkVPICReader_SetStride_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_SetXExtent_30(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetXExtent(int _arg1, int _arg2)
		{
			vtkVPICReader.vtkVPICReader_SetXExtent_30(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_SetXExtent_31(HandleRef pThis, IntPtr _arg);

		public void SetXExtent(IntPtr _arg)
		{
			vtkVPICReader.vtkVPICReader_SetXExtent_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_SetYExtent_32(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetYExtent(int _arg1, int _arg2)
		{
			vtkVPICReader.vtkVPICReader_SetYExtent_32(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_SetYExtent_33(HandleRef pThis, IntPtr _arg);

		public void SetYExtent(IntPtr _arg)
		{
			vtkVPICReader.vtkVPICReader_SetYExtent_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_SetZExtent_34(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetZExtent(int _arg1, int _arg2)
		{
			vtkVPICReader.vtkVPICReader_SetZExtent_34(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkVPICReader_SetZExtent_35(HandleRef pThis, IntPtr _arg);

		public void SetZExtent(IntPtr _arg)
		{
			vtkVPICReader.vtkVPICReader_SetZExtent_35(base.GetCppThis(), _arg);
		}
	}
}
