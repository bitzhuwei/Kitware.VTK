using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGraphLayoutView : vtkRenderView
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphLayoutView";

		public new static readonly string MRClassNameKey;

		static vtkGraphLayoutView()
		{
			vtkGraphLayoutView.MRClassNameKey = "class vtkGraphLayoutView";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphLayoutView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphLayoutView"));
		}

		public vtkGraphLayoutView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphLayoutView New()
		{
			vtkGraphLayoutView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphLayoutView.vtkGraphLayoutView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphLayoutView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGraphLayoutView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGraphLayoutView.vtkGraphLayoutView_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_AddIconType_01(HandleRef pThis, string type, int index);

		public void AddIconType(string type, int index)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_AddIconType_01(base.GetCppThis(), type, index);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_ClearIconTypes_02(HandleRef pThis);

		public void ClearIconTypes()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_ClearIconTypes_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_ColorEdgesOff_03(HandleRef pThis);

		public virtual void ColorEdgesOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_ColorEdgesOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_ColorEdgesOn_04(HandleRef pThis);

		public virtual void ColorEdgesOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_ColorEdgesOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_ColorVerticesOff_05(HandleRef pThis);

		public virtual void ColorVerticesOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_ColorVerticesOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_ColorVerticesOn_06(HandleRef pThis);

		public virtual void ColorVerticesOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_ColorVerticesOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_EdgeLabelVisibilityOff_07(HandleRef pThis);

		public virtual void EdgeLabelVisibilityOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_EdgeLabelVisibilityOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_EdgeLabelVisibilityOn_08(HandleRef pThis);

		public virtual void EdgeLabelVisibilityOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_EdgeLabelVisibilityOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_EdgeSelectionOff_09(HandleRef pThis);

		public virtual void EdgeSelectionOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_EdgeSelectionOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_EdgeSelectionOn_10(HandleRef pThis);

		public virtual void EdgeSelectionOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_EdgeSelectionOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_EdgeVisibilityOff_11(HandleRef pThis);

		public virtual void EdgeVisibilityOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_EdgeVisibilityOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_EdgeVisibilityOn_12(HandleRef pThis);

		public virtual void EdgeVisibilityOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_EdgeVisibilityOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkGraphLayoutView_GetColorEdges_13(HandleRef pThis);

		public bool GetColorEdges()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetColorEdges_13(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkGraphLayoutView_GetColorVertices_14(HandleRef pThis);

		public bool GetColorVertices()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetColorVertices_14(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutView_GetEdgeColorArrayName_15(HandleRef pThis);

		public string GetEdgeColorArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeColorArrayName_15(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutView_GetEdgeLabelArrayName_16(HandleRef pThis);

		public string GetEdgeLabelArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeLabelArrayName_16(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutView_GetEdgeLabelFontSize_17(HandleRef pThis);

		public virtual int GetEdgeLabelFontSize()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeLabelFontSize_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkGraphLayoutView_GetEdgeLabelVisibility_18(HandleRef pThis);

		public bool GetEdgeLabelVisibility()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeLabelVisibility_18(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutView_GetEdgeLayoutStrategy_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkEdgeLayoutStrategy GetEdgeLayoutStrategy()
		{
			vtkEdgeLayoutStrategy vtkEdgeLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeLayoutStrategy_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgeLayoutStrategy = (vtkEdgeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgeLayoutStrategy.Register(null);
				}
			}
			return vtkEdgeLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutView_GetEdgeLayoutStrategyName_20(HandleRef pThis);

		public string GetEdgeLayoutStrategyName()
		{
			return Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeLayoutStrategyName_20(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkGraphLayoutView_GetEdgeScalarBarVisibility_21(HandleRef pThis);

		public bool GetEdgeScalarBarVisibility()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeScalarBarVisibility_21(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkGraphLayoutView_GetEdgeSelection_22(HandleRef pThis);

		public bool GetEdgeSelection()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeSelection_22(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkGraphLayoutView_GetEdgeVisibility_23(HandleRef pThis);

		public bool GetEdgeVisibility()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeVisibility_23(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutView_GetEnableEdgesByArray_24(HandleRef pThis);

		public int GetEnableEdgesByArray()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetEnableEdgesByArray_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutView_GetEnableVerticesByArray_25(HandleRef pThis);

		public int GetEnableVerticesByArray()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetEnableVerticesByArray_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutView_GetEnabledEdgesArrayName_26(HandleRef pThis);

		public string GetEnabledEdgesArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetEnabledEdgesArrayName_26(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutView_GetEnabledVerticesArrayName_27(HandleRef pThis);

		public string GetEnabledVerticesArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetEnabledVerticesArrayName_27(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutView_GetGlyphType_28(HandleRef pThis);

		public int GetGlyphType()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetGlyphType_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkGraphLayoutView_GetHideEdgeLabelsOnInteraction_29(HandleRef pThis);

		public bool GetHideEdgeLabelsOnInteraction()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetHideEdgeLabelsOnInteraction_29(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkGraphLayoutView_GetHideVertexLabelsOnInteraction_30(HandleRef pThis);

		public bool GetHideVertexLabelsOnInteraction()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetHideVertexLabelsOnInteraction_30(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutView_GetIconArrayName_31(HandleRef pThis);

		public string GetIconArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetIconArrayName_31(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkGraphLayoutView_GetIconVisibility_32(HandleRef pThis);

		public bool GetIconVisibility()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetIconVisibility_32(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutView_GetLayoutStrategy_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGraphLayoutStrategy GetLayoutStrategy()
		{
			vtkGraphLayoutStrategy vtkGraphLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphLayoutView.vtkGraphLayoutView_GetLayoutStrategy_33(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphLayoutStrategy = (vtkGraphLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphLayoutStrategy.Register(null);
				}
			}
			return vtkGraphLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutView_GetLayoutStrategyName_34(HandleRef pThis);

		public string GetLayoutStrategyName()
		{
			return Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetLayoutStrategyName_34(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkGraphLayoutView_GetScaledGlyphs_35(HandleRef pThis);

		public bool GetScaledGlyphs()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetScaledGlyphs_35(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutView_GetScalingArrayName_36(HandleRef pThis);

		public string GetScalingArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetScalingArrayName_36(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutView_GetVertexColorArrayName_37(HandleRef pThis);

		public string GetVertexColorArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetVertexColorArrayName_37(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutView_GetVertexLabelArrayName_38(HandleRef pThis);

		public string GetVertexLabelArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetVertexLabelArrayName_38(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutView_GetVertexLabelFontSize_39(HandleRef pThis);

		public virtual int GetVertexLabelFontSize()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetVertexLabelFontSize_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkGraphLayoutView_GetVertexLabelVisibility_40(HandleRef pThis);

		public bool GetVertexLabelVisibility()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetVertexLabelVisibility_40(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkGraphLayoutView_GetVertexScalarBarVisibility_41(HandleRef pThis);

		public bool GetVertexScalarBarVisibility()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetVertexScalarBarVisibility_41(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_HideEdgeLabelsOnInteractionOff_42(HandleRef pThis);

		public virtual void HideEdgeLabelsOnInteractionOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_HideEdgeLabelsOnInteractionOff_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_HideEdgeLabelsOnInteractionOn_43(HandleRef pThis);

		public virtual void HideEdgeLabelsOnInteractionOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_HideEdgeLabelsOnInteractionOn_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_HideVertexLabelsOnInteractionOff_44(HandleRef pThis);

		public virtual void HideVertexLabelsOnInteractionOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_HideVertexLabelsOnInteractionOff_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_HideVertexLabelsOnInteractionOn_45(HandleRef pThis);

		public virtual void HideVertexLabelsOnInteractionOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_HideVertexLabelsOnInteractionOn_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_IconVisibilityOff_46(HandleRef pThis);

		public virtual void IconVisibilityOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_IconVisibilityOff_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_IconVisibilityOn_47(HandleRef pThis);

		public virtual void IconVisibilityOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_IconVisibilityOn_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutView_IsA_48(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_IsA_48(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutView_IsLayoutComplete_49(HandleRef pThis);

		public virtual int IsLayoutComplete()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_IsLayoutComplete_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutView_IsTypeOf_50(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_IsTypeOf_50(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutView_NewInstance_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraphLayoutView NewInstance()
		{
			vtkGraphLayoutView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphLayoutView.vtkGraphLayoutView_NewInstance_52(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphLayoutView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutView_SafeDownCast_53(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphLayoutView SafeDownCast(vtkObjectBase o)
		{
			vtkGraphLayoutView vtkGraphLayoutView = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphLayoutView.vtkGraphLayoutView_SafeDownCast_53((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphLayoutView = (vtkGraphLayoutView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphLayoutView.Register(null);
				}
			}
			return vtkGraphLayoutView;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_ScaledGlyphsOff_54(HandleRef pThis);

		public virtual void ScaledGlyphsOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_ScaledGlyphsOff_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_ScaledGlyphsOn_55(HandleRef pThis);

		public virtual void ScaledGlyphsOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_ScaledGlyphsOn_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetColorEdges_56(HandleRef pThis, byte vis);

		public void SetColorEdges(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetColorEdges_56(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetColorVertices_57(HandleRef pThis, byte vis);

		public void SetColorVertices(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetColorVertices_57(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetEdgeColorArrayName_58(HandleRef pThis, string name);

		public void SetEdgeColorArrayName(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeColorArrayName_58(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetEdgeLabelArrayName_59(HandleRef pThis, string name);

		public void SetEdgeLabelArrayName(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeLabelArrayName_59(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetEdgeLabelFontSize_60(HandleRef pThis, int size);

		public virtual void SetEdgeLabelFontSize(int size)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeLabelFontSize_60(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetEdgeLabelVisibility_61(HandleRef pThis, byte vis);

		public void SetEdgeLabelVisibility(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeLabelVisibility_61(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetEdgeLayoutStrategy_62(HandleRef pThis, HandleRef s);

		public void SetEdgeLayoutStrategy(vtkEdgeLayoutStrategy s)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeLayoutStrategy_62(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetEdgeLayoutStrategy_63(HandleRef pThis, string name);

		public void SetEdgeLayoutStrategy(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeLayoutStrategy_63(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetEdgeLayoutStrategyToArcParallel_64(HandleRef pThis);

		public void SetEdgeLayoutStrategyToArcParallel()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeLayoutStrategyToArcParallel_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetEdgeLayoutStrategyToPassThrough_65(HandleRef pThis);

		public void SetEdgeLayoutStrategyToPassThrough()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeLayoutStrategyToPassThrough_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetEdgeScalarBarVisibility_66(HandleRef pThis, byte vis);

		public void SetEdgeScalarBarVisibility(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeScalarBarVisibility_66(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetEdgeSelection_67(HandleRef pThis, byte vis);

		public void SetEdgeSelection(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeSelection_67(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetEdgeVisibility_68(HandleRef pThis, byte vis);

		public void SetEdgeVisibility(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeVisibility_68(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetEnableEdgesByArray_69(HandleRef pThis, byte vis);

		public void SetEnableEdgesByArray(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEnableEdgesByArray_69(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetEnableVerticesByArray_70(HandleRef pThis, byte vis);

		public void SetEnableVerticesByArray(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEnableVerticesByArray_70(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetEnabledEdgesArrayName_71(HandleRef pThis, string name);

		public void SetEnabledEdgesArrayName(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEnabledEdgesArrayName_71(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetEnabledVerticesArrayName_72(HandleRef pThis, string name);

		public void SetEnabledVerticesArrayName(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEnabledVerticesArrayName_72(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetGlyphType_73(HandleRef pThis, int type);

		public void SetGlyphType(int type)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetGlyphType_73(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetHideEdgeLabelsOnInteraction_74(HandleRef pThis, byte vis);

		public void SetHideEdgeLabelsOnInteraction(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetHideEdgeLabelsOnInteraction_74(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetHideVertexLabelsOnInteraction_75(HandleRef pThis, byte vis);

		public void SetHideVertexLabelsOnInteraction(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetHideVertexLabelsOnInteraction_75(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetIconAlignment_76(HandleRef pThis, int alignment);

		public void SetIconAlignment(int alignment)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetIconAlignment_76(base.GetCppThis(), alignment);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetIconArrayName_77(HandleRef pThis, string name);

		public void SetIconArrayName(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetIconArrayName_77(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetIconVisibility_78(HandleRef pThis, byte b);

		public void SetIconVisibility(bool b)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetIconVisibility_78(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategy_79(HandleRef pThis, string name);

		public void SetLayoutStrategy(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategy_79(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategy_80(HandleRef pThis, HandleRef s);

		public void SetLayoutStrategy(vtkGraphLayoutStrategy s)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategy_80(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToCircular_81(HandleRef pThis);

		public void SetLayoutStrategyToCircular()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToCircular_81(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToClustering2D_82(HandleRef pThis);

		public void SetLayoutStrategyToClustering2D()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToClustering2D_82(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToCommunity2D_83(HandleRef pThis);

		public void SetLayoutStrategyToCommunity2D()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToCommunity2D_83(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToCone_84(HandleRef pThis);

		public void SetLayoutStrategyToCone()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToCone_84(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToCosmicTree_85(HandleRef pThis);

		public void SetLayoutStrategyToCosmicTree()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToCosmicTree_85(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToFast2D_86(HandleRef pThis);

		public void SetLayoutStrategyToFast2D()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToFast2D_86(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToForceDirected_87(HandleRef pThis);

		public void SetLayoutStrategyToForceDirected()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToForceDirected_87(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToPassThrough_88(HandleRef pThis);

		public void SetLayoutStrategyToPassThrough()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToPassThrough_88(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToRandom_89(HandleRef pThis);

		public void SetLayoutStrategyToRandom()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToRandom_89(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToSimple2D_90(HandleRef pThis);

		public void SetLayoutStrategyToSimple2D()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToSimple2D_90(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToSpanTree_91(HandleRef pThis);

		public void SetLayoutStrategyToSpanTree()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToSpanTree_91(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToTree_92(HandleRef pThis);

		public void SetLayoutStrategyToTree()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToTree_92(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetScaledGlyphs_93(HandleRef pThis, byte arg);

		public void SetScaledGlyphs(bool arg)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetScaledGlyphs_93(base.GetCppThis(), arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetScalingArrayName_94(HandleRef pThis, string name);

		public void SetScalingArrayName(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetScalingArrayName_94(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetVertexColorArrayName_95(HandleRef pThis, string name);

		public void SetVertexColorArrayName(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetVertexColorArrayName_95(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetVertexLabelArrayName_96(HandleRef pThis, string name);

		public void SetVertexLabelArrayName(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetVertexLabelArrayName_96(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetVertexLabelFontSize_97(HandleRef pThis, int size);

		public virtual void SetVertexLabelFontSize(int size)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetVertexLabelFontSize_97(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetVertexLabelVisibility_98(HandleRef pThis, byte vis);

		public void SetVertexLabelVisibility(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetVertexLabelVisibility_98(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_SetVertexScalarBarVisibility_99(HandleRef pThis, byte vis);

		public void SetVertexScalarBarVisibility(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetVertexScalarBarVisibility_99(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_UpdateLayout_100(HandleRef pThis);

		public virtual void UpdateLayout()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_UpdateLayout_100(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_VertexLabelVisibilityOff_101(HandleRef pThis);

		public virtual void VertexLabelVisibilityOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_VertexLabelVisibilityOff_101(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_VertexLabelVisibilityOn_102(HandleRef pThis);

		public virtual void VertexLabelVisibilityOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_VertexLabelVisibilityOn_102(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutView_ZoomToSelection_103(HandleRef pThis);

		public void ZoomToSelection()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_ZoomToSelection_103(base.GetCppThis());
		}
	}
}
