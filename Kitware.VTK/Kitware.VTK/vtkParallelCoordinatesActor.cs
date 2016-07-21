using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParallelCoordinatesActor : vtkActor2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelCoordinatesActor";

		public new static readonly string MRClassNameKey;

		static vtkParallelCoordinatesActor()
		{
			vtkParallelCoordinatesActor.MRClassNameKey = "class vtkParallelCoordinatesActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelCoordinatesActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelCoordinatesActor"));
		}

		public vtkParallelCoordinatesActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelCoordinatesActor New()
		{
			vtkParallelCoordinatesActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParallelCoordinatesActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesActor_GetIndependentVariables_01(HandleRef pThis);

		public virtual int GetIndependentVariables()
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetIndependentVariables_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesActor_GetIndependentVariablesMaxValue_02(HandleRef pThis);

		public virtual int GetIndependentVariablesMaxValue()
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetIndependentVariablesMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesActor_GetIndependentVariablesMinValue_03(HandleRef pThis);

		public virtual int GetIndependentVariablesMinValue()
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetIndependentVariablesMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesActor_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetInput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesActor_GetLabelFormat_05(HandleRef pThis);

		public virtual string GetLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetLabelFormat_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesActor_GetLabelTextProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetLabelTextProperty_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesActor_GetNumberOfLabels_07(HandleRef pThis);

		public virtual int GetNumberOfLabels()
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetNumberOfLabels_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesActor_GetNumberOfLabelsMaxValue_08(HandleRef pThis);

		public virtual int GetNumberOfLabelsMaxValue()
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetNumberOfLabelsMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesActor_GetNumberOfLabelsMinValue_09(HandleRef pThis);

		public virtual int GetNumberOfLabelsMinValue()
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetNumberOfLabelsMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesActor_GetTitle_10(HandleRef pThis);

		public virtual string GetTitle()
		{
			return Marshal.PtrToStringAnsi(vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetTitle_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesActor_GetTitleTextProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetTitleTextProperty_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesActor_HasTranslucentPolygonalGeometry_12(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_HasTranslucentPolygonalGeometry_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesActor_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesActor_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesActor_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParallelCoordinatesActor NewInstance()
		{
			vtkParallelCoordinatesActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesActor_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_ReleaseGraphicsResources_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesActor_RenderOpaqueGeometry_18(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_RenderOpaqueGeometry_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesActor_RenderOverlay_19(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_RenderOverlay_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesActor_RenderTranslucentPolygonalGeometry_20(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_RenderTranslucentPolygonalGeometry_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesActor_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelCoordinatesActor SafeDownCast(vtkObjectBase o)
		{
			vtkParallelCoordinatesActor vtkParallelCoordinatesActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelCoordinatesActor = (vtkParallelCoordinatesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelCoordinatesActor.Register(null);
				}
			}
			return vtkParallelCoordinatesActor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesActor_SetIndependentVariables_22(HandleRef pThis, int _arg);

		public virtual void SetIndependentVariables(int _arg)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetIndependentVariables_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesActor_SetIndependentVariablesToColumns_23(HandleRef pThis);

		public void SetIndependentVariablesToColumns()
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetIndependentVariablesToColumns_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesActor_SetIndependentVariablesToRows_24(HandleRef pThis);

		public void SetIndependentVariablesToRows()
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetIndependentVariablesToRows_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesActor_SetInput_25(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkDataObject arg0)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetInput_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesActor_SetLabelFormat_26(HandleRef pThis, string _arg);

		public virtual void SetLabelFormat(string _arg)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetLabelFormat_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesActor_SetLabelTextProperty_27(HandleRef pThis, HandleRef p);

		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetLabelTextProperty_27(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesActor_SetNumberOfLabels_28(HandleRef pThis, int _arg);

		public virtual void SetNumberOfLabels(int _arg)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetNumberOfLabels_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesActor_SetTitle_29(HandleRef pThis, string _arg);

		public virtual void SetTitle(string _arg)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetTitle_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesActor_SetTitleTextProperty_30(HandleRef pThis, HandleRef p);

		public virtual void SetTitleTextProperty(vtkTextProperty p)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetTitleTextProperty_30(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}
	}
}
