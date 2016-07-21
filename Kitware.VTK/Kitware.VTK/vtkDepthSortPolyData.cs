using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDepthSortPolyData : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDepthSortPolyData";

		public new static readonly string MRClassNameKey;

		static vtkDepthSortPolyData()
		{
			vtkDepthSortPolyData.MRClassNameKey = "class vtkDepthSortPolyData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDepthSortPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDepthSortPolyData"));
		}

		public vtkDepthSortPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDepthSortPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDepthSortPolyData New()
		{
			vtkDepthSortPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDepthSortPolyData.vtkDepthSortPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDepthSortPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDepthSortPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDepthSortPolyData.vtkDepthSortPolyData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDepthSortPolyData_GetCamera_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDepthSortPolyData.vtkDepthSortPolyData_GetCamera_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkDepthSortPolyData_GetDepthSortMode_02(HandleRef pThis);

		public virtual int GetDepthSortMode()
		{
			return vtkDepthSortPolyData.vtkDepthSortPolyData_GetDepthSortMode_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkDepthSortPolyData_GetDirection_03(HandleRef pThis);

		public virtual int GetDirection()
		{
			return vtkDepthSortPolyData.vtkDepthSortPolyData_GetDirection_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern uint vtkDepthSortPolyData_GetMTime_04(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkDepthSortPolyData.vtkDepthSortPolyData_GetMTime_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDepthSortPolyData_GetOrigin_05(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkDepthSortPolyData.vtkDepthSortPolyData_GetOrigin_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_GetOrigin_06(HandleRef pThis, IntPtr data);

		public virtual void GetOrigin(IntPtr data)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_GetOrigin_06(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDepthSortPolyData_GetProp3D_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProp3D GetProp3D()
		{
			vtkProp3D vtkProp3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDepthSortPolyData.vtkDepthSortPolyData_GetProp3D_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3D = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3D.Register(null);
				}
			}
			return vtkProp3D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkDepthSortPolyData_GetSortScalars_08(HandleRef pThis);

		public virtual int GetSortScalars()
		{
			return vtkDepthSortPolyData.vtkDepthSortPolyData_GetSortScalars_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDepthSortPolyData_GetVector_09(HandleRef pThis);

		public virtual double[] GetVector()
		{
			IntPtr intPtr = vtkDepthSortPolyData.vtkDepthSortPolyData_GetVector_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_GetVector_10(HandleRef pThis, IntPtr data);

		public virtual void GetVector(IntPtr data)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_GetVector_10(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkDepthSortPolyData_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDepthSortPolyData.vtkDepthSortPolyData_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkDepthSortPolyData_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDepthSortPolyData.vtkDepthSortPolyData_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDepthSortPolyData_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDepthSortPolyData NewInstance()
		{
			vtkDepthSortPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDepthSortPolyData.vtkDepthSortPolyData_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDepthSortPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDepthSortPolyData_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDepthSortPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkDepthSortPolyData vtkDepthSortPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDepthSortPolyData.vtkDepthSortPolyData_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDepthSortPolyData = (vtkDepthSortPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDepthSortPolyData.Register(null);
				}
			}
			return vtkDepthSortPolyData;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SetCamera_16(HandleRef pThis, HandleRef arg0);

		public virtual void SetCamera(vtkCamera arg0)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetCamera_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SetDepthSortMode_17(HandleRef pThis, int _arg);

		public virtual void SetDepthSortMode(int _arg)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetDepthSortMode_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SetDepthSortModeToBoundsCenter_18(HandleRef pThis);

		public void SetDepthSortModeToBoundsCenter()
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetDepthSortModeToBoundsCenter_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SetDepthSortModeToFirstPoint_19(HandleRef pThis);

		public void SetDepthSortModeToFirstPoint()
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetDepthSortModeToFirstPoint_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SetDepthSortModeToParametricCenter_20(HandleRef pThis);

		public void SetDepthSortModeToParametricCenter()
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetDepthSortModeToParametricCenter_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SetDirection_21(HandleRef pThis, int _arg);

		public virtual void SetDirection(int _arg)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetDirection_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SetDirectionToBackToFront_22(HandleRef pThis);

		public void SetDirectionToBackToFront()
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetDirectionToBackToFront_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SetDirectionToFrontToBack_23(HandleRef pThis);

		public void SetDirectionToFrontToBack()
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetDirectionToFrontToBack_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SetDirectionToSpecifiedVector_24(HandleRef pThis);

		public void SetDirectionToSpecifiedVector()
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetDirectionToSpecifiedVector_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SetOrigin_25(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetOrigin_25(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SetOrigin_26(HandleRef pThis, IntPtr _arg);

		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetOrigin_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SetProp3D_27(HandleRef pThis, HandleRef arg0);

		public void SetProp3D(vtkProp3D arg0)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetProp3D_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SetSortScalars_28(HandleRef pThis, int _arg);

		public virtual void SetSortScalars(int _arg)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetSortScalars_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SetVector_29(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetVector(double _arg1, double _arg2, double _arg3)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetVector_29(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SetVector_30(HandleRef pThis, IntPtr _arg);

		public virtual void SetVector(IntPtr _arg)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetVector_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SortScalarsOff_31(HandleRef pThis);

		public virtual void SortScalarsOff()
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SortScalarsOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDepthSortPolyData_SortScalarsOn_32(HandleRef pThis);

		public virtual void SortScalarsOn()
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SortScalarsOn_32(base.GetCppThis());
		}
	}
}
