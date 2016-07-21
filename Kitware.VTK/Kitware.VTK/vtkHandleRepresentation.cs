using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkHandleRepresentation : vtkWidgetRepresentation
	{
		public enum _InteractionState
		{
			Nearby = 1,
			Outside = 0,
			Scaling = 4,
			Selecting = 2,
			Translating
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkHandleRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkHandleRepresentation()
		{
			vtkHandleRepresentation.MRClassNameKey = "class vtkHandleRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHandleRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHandleRepresentation"));
		}

		public vtkHandleRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleRepresentation_ActiveRepresentationOff_01(HandleRef pThis);

		public virtual void ActiveRepresentationOff()
		{
			vtkHandleRepresentation.vtkHandleRepresentation_ActiveRepresentationOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleRepresentation_ActiveRepresentationOn_02(HandleRef pThis);

		public virtual void ActiveRepresentationOn()
		{
			vtkHandleRepresentation.vtkHandleRepresentation_ActiveRepresentationOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHandleRepresentation_CheckConstraint_03(HandleRef pThis, HandleRef renderer, IntPtr pos);

		public virtual int CheckConstraint(vtkRenderer renderer, IntPtr pos)
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_CheckConstraint_03(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleRepresentation_ConstrainedOff_04(HandleRef pThis);

		public virtual void ConstrainedOff()
		{
			vtkHandleRepresentation.vtkHandleRepresentation_ConstrainedOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleRepresentation_ConstrainedOn_05(HandleRef pThis);

		public virtual void ConstrainedOn()
		{
			vtkHandleRepresentation.vtkHandleRepresentation_ConstrainedOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleRepresentation_DeepCopy_06(HandleRef pThis, HandleRef prop);

		public virtual void DeepCopy(vtkProp prop)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_DeepCopy_06(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHandleRepresentation_GetActiveRepresentation_07(HandleRef pThis);

		public virtual int GetActiveRepresentation()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetActiveRepresentation_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHandleRepresentation_GetConstrained_08(HandleRef pThis);

		public virtual int GetConstrained()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetConstrained_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleRepresentation_GetDisplayPosition_09(HandleRef pThis, IntPtr pos);

		public virtual void GetDisplayPosition(IntPtr pos)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_GetDisplayPosition_09(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkHandleRepresentation_GetDisplayPosition_10(HandleRef pThis);

		public virtual double[] GetDisplayPosition()
		{
			IntPtr intPtr = vtkHandleRepresentation.vtkHandleRepresentation_GetDisplayPosition_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHandleRepresentation_GetInteractionStateMaxValue_11(HandleRef pThis);

		public virtual int GetInteractionStateMaxValue()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetInteractionStateMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHandleRepresentation_GetInteractionStateMinValue_12(HandleRef pThis);

		public virtual int GetInteractionStateMinValue()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetInteractionStateMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern uint vtkHandleRepresentation_GetMTime_13(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetMTime_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkHandleRepresentation_GetPointPlacer_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPointPlacer GetPointPlacer()
		{
			vtkPointPlacer vtkPointPlacer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHandleRepresentation.vtkHandleRepresentation_GetPointPlacer_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointPlacer = (vtkPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointPlacer.Register(null);
				}
			}
			return vtkPointPlacer;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHandleRepresentation_GetTolerance_15(HandleRef pThis);

		public virtual int GetTolerance()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetTolerance_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHandleRepresentation_GetToleranceMaxValue_16(HandleRef pThis);

		public virtual int GetToleranceMaxValue()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetToleranceMaxValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHandleRepresentation_GetToleranceMinValue_17(HandleRef pThis);

		public virtual int GetToleranceMinValue()
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_GetToleranceMinValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleRepresentation_GetWorldPosition_18(HandleRef pThis, IntPtr pos);

		public virtual void GetWorldPosition(IntPtr pos)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_GetWorldPosition_18(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkHandleRepresentation_GetWorldPosition_19(HandleRef pThis);

		public virtual double[] GetWorldPosition()
		{
			IntPtr intPtr = vtkHandleRepresentation.vtkHandleRepresentation_GetWorldPosition_19(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHandleRepresentation_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHandleRepresentation_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHandleRepresentation.vtkHandleRepresentation_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkHandleRepresentation_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHandleRepresentation NewInstance()
		{
			vtkHandleRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHandleRepresentation.vtkHandleRepresentation_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkHandleRepresentation_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHandleRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHandleRepresentation.vtkHandleRepresentation_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleRepresentation = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleRepresentation.Register(null);
				}
			}
			return vtkHandleRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleRepresentation_SetActiveRepresentation_24(HandleRef pThis, int _arg);

		public virtual void SetActiveRepresentation(int _arg)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetActiveRepresentation_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleRepresentation_SetConstrained_25(HandleRef pThis, int _arg);

		public virtual void SetConstrained(int _arg)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetConstrained_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleRepresentation_SetDisplayPosition_26(HandleRef pThis, IntPtr pos);

		public virtual void SetDisplayPosition(IntPtr pos)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetDisplayPosition_26(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleRepresentation_SetInteractionState_27(HandleRef pThis, int _arg);

		public virtual void SetInteractionState(int _arg)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetInteractionState_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleRepresentation_SetPointPlacer_28(HandleRef pThis, HandleRef arg0);

		public virtual void SetPointPlacer(vtkPointPlacer arg0)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetPointPlacer_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleRepresentation_SetRenderer_29(HandleRef pThis, HandleRef ren);

		public override void SetRenderer(vtkRenderer ren)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetRenderer_29(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleRepresentation_SetTolerance_30(HandleRef pThis, int _arg);

		public virtual void SetTolerance(int _arg)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetTolerance_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleRepresentation_SetWorldPosition_31(HandleRef pThis, IntPtr pos);

		public virtual void SetWorldPosition(IntPtr pos)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_SetWorldPosition_31(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHandleRepresentation_ShallowCopy_32(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkHandleRepresentation.vtkHandleRepresentation_ShallowCopy_32(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}
