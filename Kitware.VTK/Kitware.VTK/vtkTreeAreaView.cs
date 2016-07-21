using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTreeAreaView : vtkRenderView
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeAreaView";

		public new static readonly string MRClassNameKey;

		static vtkTreeAreaView()
		{
			vtkTreeAreaView.MRClassNameKey = "class vtkTreeAreaView";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeAreaView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeAreaView"));
		}

		public vtkTreeAreaView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeAreaView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeAreaView New()
		{
			vtkTreeAreaView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeAreaView.vtkTreeAreaView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeAreaView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTreeAreaView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTreeAreaView.vtkTreeAreaView_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_AreaLabelVisibilityOff_01(HandleRef pThis);

		public virtual void AreaLabelVisibilityOff()
		{
			vtkTreeAreaView.vtkTreeAreaView_AreaLabelVisibilityOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_AreaLabelVisibilityOn_02(HandleRef pThis);

		public virtual void AreaLabelVisibilityOn()
		{
			vtkTreeAreaView.vtkTreeAreaView_AreaLabelVisibilityOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_ColorAreasOff_03(HandleRef pThis);

		public virtual void ColorAreasOff()
		{
			vtkTreeAreaView.vtkTreeAreaView_ColorAreasOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_ColorAreasOn_04(HandleRef pThis);

		public virtual void ColorAreasOn()
		{
			vtkTreeAreaView.vtkTreeAreaView_ColorAreasOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_ColorEdgesOff_05(HandleRef pThis);

		public virtual void ColorEdgesOff()
		{
			vtkTreeAreaView.vtkTreeAreaView_ColorEdgesOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_ColorEdgesOn_06(HandleRef pThis);

		public virtual void ColorEdgesOn()
		{
			vtkTreeAreaView.vtkTreeAreaView_ColorEdgesOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_EdgeLabelVisibilityOff_07(HandleRef pThis);

		public virtual void EdgeLabelVisibilityOff()
		{
			vtkTreeAreaView.vtkTreeAreaView_EdgeLabelVisibilityOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_EdgeLabelVisibilityOn_08(HandleRef pThis);

		public virtual void EdgeLabelVisibilityOn()
		{
			vtkTreeAreaView.vtkTreeAreaView_EdgeLabelVisibilityOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeAreaView_GetAreaColorArrayName_09(HandleRef pThis);

		public string GetAreaColorArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkTreeAreaView.vtkTreeAreaView_GetAreaColorArrayName_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeAreaView_GetAreaHoverArrayName_10(HandleRef pThis);

		public string GetAreaHoverArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkTreeAreaView.vtkTreeAreaView_GetAreaHoverArrayName_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeAreaView_GetAreaLabelArrayName_11(HandleRef pThis);

		public string GetAreaLabelArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkTreeAreaView.vtkTreeAreaView_GetAreaLabelArrayName_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkTreeAreaView_GetAreaLabelFontSize_12(HandleRef pThis);

		public virtual int GetAreaLabelFontSize()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetAreaLabelFontSize_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkTreeAreaView_GetAreaLabelVisibility_13(HandleRef pThis);

		public bool GetAreaLabelVisibility()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetAreaLabelVisibility_13(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeAreaView_GetAreaSizeArrayName_14(HandleRef pThis);

		public string GetAreaSizeArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkTreeAreaView.vtkTreeAreaView_GetAreaSizeArrayName_14(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkTreeAreaView_GetBundlingStrength_15(HandleRef pThis);

		public double GetBundlingStrength()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetBundlingStrength_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkTreeAreaView_GetColorAreas_16(HandleRef pThis);

		public bool GetColorAreas()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetColorAreas_16(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkTreeAreaView_GetColorEdges_17(HandleRef pThis);

		public bool GetColorEdges()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetColorEdges_17(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeAreaView_GetEdgeColorArrayName_18(HandleRef pThis);

		public string GetEdgeColorArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkTreeAreaView.vtkTreeAreaView_GetEdgeColorArrayName_18(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeAreaView_GetEdgeLabelArrayName_19(HandleRef pThis);

		public string GetEdgeLabelArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkTreeAreaView.vtkTreeAreaView_GetEdgeLabelArrayName_19(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkTreeAreaView_GetEdgeLabelFontSize_20(HandleRef pThis);

		public virtual int GetEdgeLabelFontSize()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetEdgeLabelFontSize_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkTreeAreaView_GetEdgeLabelVisibility_21(HandleRef pThis);

		public bool GetEdgeLabelVisibility()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetEdgeLabelVisibility_21(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkTreeAreaView_GetEdgeScalarBarVisibility_22(HandleRef pThis);

		public virtual bool GetEdgeScalarBarVisibility()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetEdgeScalarBarVisibility_22(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeAreaView_GetLabelPriorityArrayName_23(HandleRef pThis);

		public string GetLabelPriorityArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkTreeAreaView.vtkTreeAreaView_GetLabelPriorityArrayName_23(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeAreaView_GetLayoutStrategy_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAreaLayoutStrategy GetLayoutStrategy()
		{
			vtkAreaLayoutStrategy vtkAreaLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeAreaView.vtkTreeAreaView_GetLayoutStrategy_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAreaLayoutStrategy = (vtkAreaLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAreaLayoutStrategy.Register(null);
				}
			}
			return vtkAreaLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkTreeAreaView_GetShrinkPercentage_25(HandleRef pThis);

		public double GetShrinkPercentage()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetShrinkPercentage_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkTreeAreaView_GetUseRectangularCoordinates_26(HandleRef pThis);

		public virtual bool GetUseRectangularCoordinates()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetUseRectangularCoordinates_26(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkTreeAreaView_IsA_27(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTreeAreaView.vtkTreeAreaView_IsA_27(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkTreeAreaView_IsTypeOf_28(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTreeAreaView.vtkTreeAreaView_IsTypeOf_28(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeAreaView_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTreeAreaView NewInstance()
		{
			vtkTreeAreaView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeAreaView.vtkTreeAreaView_NewInstance_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeAreaView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeAreaView_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeAreaView SafeDownCast(vtkObjectBase o)
		{
			vtkTreeAreaView vtkTreeAreaView = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeAreaView.vtkTreeAreaView_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeAreaView = (vtkTreeAreaView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeAreaView.Register(null);
				}
			}
			return vtkTreeAreaView;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetAreaColorArrayName_32(HandleRef pThis, string name);

		public void SetAreaColorArrayName(string name)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetAreaColorArrayName_32(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetAreaHoverArrayName_33(HandleRef pThis, string name);

		public void SetAreaHoverArrayName(string name)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetAreaHoverArrayName_33(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetAreaLabelArrayName_34(HandleRef pThis, string name);

		public void SetAreaLabelArrayName(string name)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetAreaLabelArrayName_34(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetAreaLabelFontSize_35(HandleRef pThis, int size);

		public virtual void SetAreaLabelFontSize(int size)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetAreaLabelFontSize_35(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetAreaLabelVisibility_36(HandleRef pThis, byte vis);

		public void SetAreaLabelVisibility(bool vis)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetAreaLabelVisibility_36(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetAreaSizeArrayName_37(HandleRef pThis, string name);

		public void SetAreaSizeArrayName(string name)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetAreaSizeArrayName_37(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetBundlingStrength_38(HandleRef pThis, double strength);

		public void SetBundlingStrength(double strength)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetBundlingStrength_38(base.GetCppThis(), strength);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetColorAreas_39(HandleRef pThis, byte vis);

		public void SetColorAreas(bool vis)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetColorAreas_39(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetColorEdges_40(HandleRef pThis, byte vis);

		public void SetColorEdges(bool vis)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetColorEdges_40(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetEdgeColorArrayName_41(HandleRef pThis, string name);

		public void SetEdgeColorArrayName(string name)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetEdgeColorArrayName_41(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetEdgeColorToSplineFraction_42(HandleRef pThis);

		public void SetEdgeColorToSplineFraction()
		{
			vtkTreeAreaView.vtkTreeAreaView_SetEdgeColorToSplineFraction_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetEdgeLabelArrayName_43(HandleRef pThis, string name);

		public void SetEdgeLabelArrayName(string name)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetEdgeLabelArrayName_43(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetEdgeLabelFontSize_44(HandleRef pThis, int size);

		public virtual void SetEdgeLabelFontSize(int size)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetEdgeLabelFontSize_44(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetEdgeLabelVisibility_45(HandleRef pThis, byte vis);

		public void SetEdgeLabelVisibility(bool vis)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetEdgeLabelVisibility_45(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetEdgeScalarBarVisibility_46(HandleRef pThis, byte b);

		public virtual void SetEdgeScalarBarVisibility(bool b)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetEdgeScalarBarVisibility_46(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeAreaView_SetGraphFromInput_47(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataRepresentation SetGraphFromInput(vtkGraph input)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeAreaView.vtkTreeAreaView_SetGraphFromInput_47(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeAreaView_SetGraphFromInputConnection_48(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataRepresentation SetGraphFromInputConnection(vtkAlgorithmOutput conn)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeAreaView.vtkTreeAreaView_SetGraphFromInputConnection_48(base.GetCppThis(), (conn == null) ? default(HandleRef) : conn.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetLabelPriorityArrayName_49(HandleRef pThis, string name);

		public void SetLabelPriorityArrayName(string name)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetLabelPriorityArrayName_49(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetLayoutStrategy_50(HandleRef pThis, HandleRef strategy);

		public virtual void SetLayoutStrategy(vtkAreaLayoutStrategy strategy)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetLayoutStrategy_50(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetShrinkPercentage_51(HandleRef pThis, double value);

		public void SetShrinkPercentage(double value)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetShrinkPercentage_51(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeAreaView_SetTreeFromInput_52(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataRepresentation SetTreeFromInput(vtkTree input)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeAreaView.vtkTreeAreaView_SetTreeFromInput_52(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeAreaView_SetTreeFromInputConnection_53(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataRepresentation SetTreeFromInputConnection(vtkAlgorithmOutput conn)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeAreaView.vtkTreeAreaView_SetTreeFromInputConnection_53(base.GetCppThis(), (conn == null) ? default(HandleRef) : conn.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_SetUseRectangularCoordinates_54(HandleRef pThis, byte rect);

		public virtual void SetUseRectangularCoordinates(bool rect)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetUseRectangularCoordinates_54(base.GetCppThis(), rect ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_UseRectangularCoordinatesOff_55(HandleRef pThis);

		public virtual void UseRectangularCoordinatesOff()
		{
			vtkTreeAreaView.vtkTreeAreaView_UseRectangularCoordinatesOff_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeAreaView_UseRectangularCoordinatesOn_56(HandleRef pThis);

		public virtual void UseRectangularCoordinatesOn()
		{
			vtkTreeAreaView.vtkTreeAreaView_UseRectangularCoordinatesOn_56(base.GetCppThis());
		}
	}
}
