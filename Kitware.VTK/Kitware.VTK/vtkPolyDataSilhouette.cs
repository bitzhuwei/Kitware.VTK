using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolyDataSilhouette : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataSilhouette";

		public new static readonly string MRClassNameKey;

		static vtkPolyDataSilhouette()
		{
			vtkPolyDataSilhouette.MRClassNameKey = "class vtkPolyDataSilhouette";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataSilhouette.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataSilhouette"));
		}

		public vtkPolyDataSilhouette(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataSilhouette_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataSilhouette New()
		{
			vtkPolyDataSilhouette result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataSilhouette.vtkPolyDataSilhouette_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataSilhouette)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolyDataSilhouette() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolyDataSilhouette.vtkPolyDataSilhouette_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_BorderEdgesOff_01(HandleRef pThis);

		public virtual void BorderEdgesOff()
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_BorderEdgesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_BorderEdgesOn_02(HandleRef pThis);

		public virtual void BorderEdgesOn()
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_BorderEdgesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPolyDataSilhouette_GetBorderEdges_03(HandleRef pThis);

		public virtual int GetBorderEdges()
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetBorderEdges_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataSilhouette_GetCamera_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetCamera_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPolyDataSilhouette_GetDirection_05(HandleRef pThis);

		public virtual int GetDirection()
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetDirection_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPolyDataSilhouette_GetEnableFeatureAngle_06(HandleRef pThis);

		public virtual int GetEnableFeatureAngle()
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetEnableFeatureAngle_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkPolyDataSilhouette_GetFeatureAngle_07(HandleRef pThis);

		public virtual double GetFeatureAngle()
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetFeatureAngle_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern uint vtkPolyDataSilhouette_GetMTime_08(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetMTime_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataSilhouette_GetOrigin_09(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetOrigin_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_GetOrigin_10(HandleRef pThis, IntPtr data);

		public virtual void GetOrigin(IntPtr data)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetOrigin_10(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPolyDataSilhouette_GetPieceInvariant_11(HandleRef pThis);

		public virtual int GetPieceInvariant()
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetPieceInvariant_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataSilhouette_GetProp3D_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProp3D GetProp3D()
		{
			vtkProp3D vtkProp3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetProp3D_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkPolyDataSilhouette_GetVector_13(HandleRef pThis);

		public virtual double[] GetVector()
		{
			IntPtr intPtr = vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetVector_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_GetVector_14(HandleRef pThis, IntPtr data);

		public virtual void GetVector(IntPtr data)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetVector_14(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPolyDataSilhouette_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPolyDataSilhouette_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataSilhouette_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyDataSilhouette NewInstance()
		{
			vtkPolyDataSilhouette result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataSilhouette.vtkPolyDataSilhouette_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataSilhouette)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_PieceInvariantOff_19(HandleRef pThis);

		public virtual void PieceInvariantOff()
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_PieceInvariantOff_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_PieceInvariantOn_20(HandleRef pThis);

		public virtual void PieceInvariantOn()
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_PieceInvariantOn_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataSilhouette_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataSilhouette SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataSilhouette vtkPolyDataSilhouette = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataSilhouette.vtkPolyDataSilhouette_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataSilhouette = (vtkPolyDataSilhouette)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataSilhouette.Register(null);
				}
			}
			return vtkPolyDataSilhouette;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_SetBorderEdges_22(HandleRef pThis, int _arg);

		public virtual void SetBorderEdges(int _arg)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetBorderEdges_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_SetCamera_23(HandleRef pThis, HandleRef arg0);

		public virtual void SetCamera(vtkCamera arg0)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetCamera_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_SetDirection_24(HandleRef pThis, int _arg);

		public virtual void SetDirection(int _arg)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetDirection_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_SetDirectionToCameraOrigin_25(HandleRef pThis);

		public void SetDirectionToCameraOrigin()
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetDirectionToCameraOrigin_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_SetDirectionToCameraVector_26(HandleRef pThis);

		public void SetDirectionToCameraVector()
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetDirectionToCameraVector_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_SetDirectionToSpecifiedOrigin_27(HandleRef pThis);

		public void SetDirectionToSpecifiedOrigin()
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetDirectionToSpecifiedOrigin_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_SetDirectionToSpecifiedVector_28(HandleRef pThis);

		public void SetDirectionToSpecifiedVector()
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetDirectionToSpecifiedVector_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_SetEnableFeatureAngle_29(HandleRef pThis, int _arg);

		public virtual void SetEnableFeatureAngle(int _arg)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetEnableFeatureAngle_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_SetFeatureAngle_30(HandleRef pThis, double _arg);

		public virtual void SetFeatureAngle(double _arg)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetFeatureAngle_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_SetOrigin_31(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetOrigin_31(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_SetOrigin_32(HandleRef pThis, IntPtr _arg);

		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetOrigin_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_SetPieceInvariant_33(HandleRef pThis, int _arg);

		public virtual void SetPieceInvariant(int _arg)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetPieceInvariant_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_SetProp3D_34(HandleRef pThis, HandleRef arg0);

		public void SetProp3D(vtkProp3D arg0)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetProp3D_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_SetVector_35(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetVector(double _arg1, double _arg2, double _arg3)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetVector_35(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataSilhouette_SetVector_36(HandleRef pThis, IntPtr _arg);

		public virtual void SetVector(IntPtr _arg)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetVector_36(base.GetCppThis(), _arg);
		}
	}
}
