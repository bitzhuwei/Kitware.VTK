using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkTensorProbeRepresentation : vtkWidgetRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTensorProbeRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkTensorProbeRepresentation()
		{
			vtkTensorProbeRepresentation.MRClassNameKey = "class vtkTensorProbeRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTensorProbeRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTensorProbeRepresentation"));
		}

		public vtkTensorProbeRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTensorProbeRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTensorProbeRepresentation_GetActors_02(HandleRef pThis, HandleRef arg0);

		public override void GetActors(vtkPropCollection arg0)
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_GetActors_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern long vtkTensorProbeRepresentation_GetProbeCellId_03(HandleRef pThis);

		public virtual long GetProbeCellId()
		{
			return vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_GetProbeCellId_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTensorProbeRepresentation_GetProbePosition_04(HandleRef pThis);

		public virtual double[] GetProbePosition()
		{
			IntPtr intPtr = vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_GetProbePosition_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTensorProbeRepresentation_GetProbePosition_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetProbePosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_GetProbePosition_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTensorProbeRepresentation_GetProbePosition_06(HandleRef pThis, IntPtr _arg);

		public virtual void GetProbePosition(IntPtr _arg)
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_GetProbePosition_06(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTensorProbeRepresentation_Initialize_07(HandleRef pThis);

		public void Initialize()
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_Initialize_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTensorProbeRepresentation_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTensorProbeRepresentation_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTensorProbeRepresentation_Move_10(HandleRef pThis, IntPtr motionVector);

		public virtual int Move(IntPtr motionVector)
		{
			return vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_Move_10(base.GetCppThis(), motionVector);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTensorProbeRepresentation_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTensorProbeRepresentation NewInstance()
		{
			vtkTensorProbeRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTensorProbeRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTensorProbeRepresentation_ReleaseGraphicsResources_12(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_ReleaseGraphicsResources_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTensorProbeRepresentation_RenderOpaqueGeometry_13(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_RenderOpaqueGeometry_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTensorProbeRepresentation_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTensorProbeRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkTensorProbeRepresentation vtkTensorProbeRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTensorProbeRepresentation = (vtkTensorProbeRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTensorProbeRepresentation.Register(null);
				}
			}
			return vtkTensorProbeRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTensorProbeRepresentation_SelectProbe_15(HandleRef pThis, IntPtr pos);

		public virtual int SelectProbe(IntPtr pos)
		{
			return vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_SelectProbe_15(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTensorProbeRepresentation_SetProbeCellId_16(HandleRef pThis, long _arg);

		public virtual void SetProbeCellId(long _arg)
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_SetProbeCellId_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTensorProbeRepresentation_SetProbePosition_17(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetProbePosition(double _arg1, double _arg2, double _arg3)
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_SetProbePosition_17(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTensorProbeRepresentation_SetProbePosition_18(HandleRef pThis, IntPtr _arg);

		public virtual void SetProbePosition(IntPtr _arg)
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_SetProbePosition_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTensorProbeRepresentation_SetTrajectory_19(HandleRef pThis, HandleRef arg0);

		public virtual void SetTrajectory(vtkPolyData arg0)
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_SetTrajectory_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
