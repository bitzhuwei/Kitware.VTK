using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRenderedGraphRepresentation : vtkRenderedRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderedGraphRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkRenderedGraphRepresentation()
		{
			vtkRenderedGraphRepresentation.MRClassNameKey = "class vtkRenderedGraphRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderedGraphRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderedGraphRepresentation"));
		}

		public vtkRenderedGraphRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderedGraphRepresentation New()
		{
			vtkRenderedGraphRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedGraphRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRenderedGraphRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_AddEdgeIconType_01(HandleRef pThis, string name, int type);

		public virtual void AddEdgeIconType(string name, int type)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_AddEdgeIconType_01(base.GetCppThis(), name, type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_AddVertexIconType_02(HandleRef pThis, string name, int type);

		public virtual void AddVertexIconType(string name, int type)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_AddVertexIconType_02(base.GetCppThis(), name, type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_ApplyViewTheme_03(HandleRef pThis, HandleRef theme);

		public override void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ApplyViewTheme_03(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_ClearEdgeIconTypes_04(HandleRef pThis);

		public virtual void ClearEdgeIconTypes()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ClearEdgeIconTypes_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_ClearVertexIconTypes_05(HandleRef pThis);

		public virtual void ClearVertexIconTypes()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ClearVertexIconTypes_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_ColorEdgesByArrayOff_06(HandleRef pThis);

		public virtual void ColorEdgesByArrayOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ColorEdgesByArrayOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_ColorEdgesByArrayOn_07(HandleRef pThis);

		public virtual void ColorEdgesByArrayOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ColorEdgesByArrayOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_ColorVerticesByArrayOff_08(HandleRef pThis);

		public virtual void ColorVerticesByArrayOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ColorVerticesByArrayOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_ColorVerticesByArrayOn_09(HandleRef pThis);

		public virtual void ColorVerticesByArrayOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ColorVerticesByArrayOn_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_ComputeSelectedGraphBounds_10(HandleRef pThis, IntPtr bounds);

		public void ComputeSelectedGraphBounds(IntPtr bounds)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ComputeSelectedGraphBounds_10(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_EdgeIconVisibilityOff_11(HandleRef pThis);

		public virtual void EdgeIconVisibilityOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EdgeIconVisibilityOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_EdgeIconVisibilityOn_12(HandleRef pThis);

		public virtual void EdgeIconVisibilityOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EdgeIconVisibilityOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_EdgeLabelVisibilityOff_13(HandleRef pThis);

		public virtual void EdgeLabelVisibilityOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EdgeLabelVisibilityOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_EdgeLabelVisibilityOn_14(HandleRef pThis);

		public virtual void EdgeLabelVisibilityOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EdgeLabelVisibilityOn_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_EdgeVisibilityOff_15(HandleRef pThis);

		public virtual void EdgeVisibilityOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EdgeVisibilityOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_EdgeVisibilityOn_16(HandleRef pThis);

		public virtual void EdgeVisibilityOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EdgeVisibilityOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_EnableEdgesByArrayOff_17(HandleRef pThis);

		public virtual void EnableEdgesByArrayOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EnableEdgesByArrayOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_EnableEdgesByArrayOn_18(HandleRef pThis);

		public virtual void EnableEdgesByArrayOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EnableEdgesByArrayOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_EnableVerticesByArrayOff_19(HandleRef pThis);

		public virtual void EnableVerticesByArrayOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EnableVerticesByArrayOff_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_EnableVerticesByArrayOn_20(HandleRef pThis);

		public virtual void EnableVerticesByArrayOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EnableVerticesByArrayOn_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetColorEdgesByArray_21(HandleRef pThis);

		public virtual bool GetColorEdgesByArray()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetColorEdgesByArray_21(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetColorVerticesByArray_22(HandleRef pThis);

		public virtual bool GetColorVerticesByArray()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetColorVerticesByArray_22(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeColorArrayName_23(HandleRef pThis);

		public virtual string GetEdgeColorArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeColorArrayName_23(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeHoverArrayName_24(HandleRef pThis);

		public virtual string GetEdgeHoverArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeHoverArrayName_24(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedGraphRepresentation_GetEdgeIconAlignment_25(HandleRef pThis);

		public virtual int GetEdgeIconAlignment()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeIconAlignment_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeIconArrayName_26(HandleRef pThis);

		public virtual string GetEdgeIconArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeIconArrayName_26(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeIconPriorityArrayName_27(HandleRef pThis);

		public virtual string GetEdgeIconPriorityArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeIconPriorityArrayName_27(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetEdgeIconVisibility_28(HandleRef pThis);

		public virtual bool GetEdgeIconVisibility()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeIconVisibility_28(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeLabelArrayName_29(HandleRef pThis);

		public virtual string GetEdgeLabelArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeLabelArrayName_29(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeLabelPriorityArrayName_30(HandleRef pThis);

		public virtual string GetEdgeLabelPriorityArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeLabelPriorityArrayName_30(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeLabelTextProperty_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetEdgeLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeLabelTextProperty_31(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetEdgeLabelVisibility_32(HandleRef pThis);

		public virtual bool GetEdgeLabelVisibility()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeLabelVisibility_32(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeLayoutStrategy_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkEdgeLayoutStrategy GetEdgeLayoutStrategy()
		{
			vtkEdgeLayoutStrategy vtkEdgeLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeLayoutStrategy_33(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeLayoutStrategyName_34(HandleRef pThis);

		public virtual string GetEdgeLayoutStrategyName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeLayoutStrategyName_34(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetEdgeScalarBarVisibility_35(HandleRef pThis);

		public virtual bool GetEdgeScalarBarVisibility()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeScalarBarVisibility_35(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetEdgeSelection_36(HandleRef pThis);

		public bool GetEdgeSelection()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeSelection_36(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetEdgeVisibility_37(HandleRef pThis);

		public virtual bool GetEdgeVisibility()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeVisibility_37(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetEnableEdgesByArray_38(HandleRef pThis);

		public virtual bool GetEnableEdgesByArray()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEnableEdgesByArray_38(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetEnableVerticesByArray_39(HandleRef pThis);

		public virtual bool GetEnableVerticesByArray()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEnableVerticesByArray_39(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEnabledEdgesArrayName_40(HandleRef pThis);

		public virtual string GetEnabledEdgesArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEnabledEdgesArrayName_40(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEnabledVerticesArrayName_41(HandleRef pThis);

		public virtual string GetEnabledVerticesArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEnabledVerticesArrayName_41(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedGraphRepresentation_GetGlyphType_42(HandleRef pThis);

		public virtual int GetGlyphType()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetGlyphType_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetHideEdgeLabelsOnInteraction_43(HandleRef pThis);

		public virtual bool GetHideEdgeLabelsOnInteraction()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetHideEdgeLabelsOnInteraction_43(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetHideVertexLabelsOnInteraction_44(HandleRef pThis);

		public virtual bool GetHideVertexLabelsOnInteraction()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetHideVertexLabelsOnInteraction_44(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetLayoutStrategy_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGraphLayoutStrategy GetLayoutStrategy()
		{
			vtkGraphLayoutStrategy vtkGraphLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetLayoutStrategy_45(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetLayoutStrategyName_46(HandleRef pThis);

		public virtual string GetLayoutStrategyName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetLayoutStrategyName_46(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetScaling_47(HandleRef pThis);

		public virtual bool GetScaling()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetScaling_47(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetScalingArrayName_48(HandleRef pThis);

		public virtual string GetScalingArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetScalingArrayName_48(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetUseEdgeIconTypeMap_49(HandleRef pThis);

		public virtual bool GetUseEdgeIconTypeMap()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetUseEdgeIconTypeMap_49(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetUseVertexIconTypeMap_50(HandleRef pThis);

		public virtual bool GetUseVertexIconTypeMap()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetUseVertexIconTypeMap_50(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexColorArrayName_51(HandleRef pThis);

		public virtual string GetVertexColorArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexColorArrayName_51(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedGraphRepresentation_GetVertexDefaultIcon_52(HandleRef pThis);

		public virtual int GetVertexDefaultIcon()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexDefaultIcon_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexHoverArrayName_53(HandleRef pThis);

		public virtual string GetVertexHoverArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexHoverArrayName_53(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedGraphRepresentation_GetVertexIconAlignment_54(HandleRef pThis);

		public virtual int GetVertexIconAlignment()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexIconAlignment_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexIconArrayName_55(HandleRef pThis);

		public virtual string GetVertexIconArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexIconArrayName_55(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexIconPriorityArrayName_56(HandleRef pThis);

		public virtual string GetVertexIconPriorityArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexIconPriorityArrayName_56(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedGraphRepresentation_GetVertexIconSelectionMode_57(HandleRef pThis);

		public virtual int GetVertexIconSelectionMode()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexIconSelectionMode_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetVertexIconVisibility_58(HandleRef pThis);

		public virtual bool GetVertexIconVisibility()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexIconVisibility_58(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexLabelArrayName_59(HandleRef pThis);

		public virtual string GetVertexLabelArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexLabelArrayName_59(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexLabelPriorityArrayName_60(HandleRef pThis);

		public virtual string GetVertexLabelPriorityArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexLabelPriorityArrayName_60(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexLabelTextProperty_61(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetVertexLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexLabelTextProperty_61(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetVertexLabelVisibility_62(HandleRef pThis);

		public virtual bool GetVertexLabelVisibility()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexLabelVisibility_62(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_GetVertexScalarBarVisibility_63(HandleRef pThis);

		public virtual bool GetVertexScalarBarVisibility()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexScalarBarVisibility_63(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedGraphRepresentation_GetVertexSelectedIcon_64(HandleRef pThis);

		public virtual int GetVertexSelectedIcon()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexSelectedIcon_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_HideEdgeLabelsOnInteractionOff_65(HandleRef pThis);

		public virtual void HideEdgeLabelsOnInteractionOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_HideEdgeLabelsOnInteractionOff_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_HideEdgeLabelsOnInteractionOn_66(HandleRef pThis);

		public virtual void HideEdgeLabelsOnInteractionOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_HideEdgeLabelsOnInteractionOn_66(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_HideVertexLabelsOnInteractionOff_67(HandleRef pThis);

		public virtual void HideVertexLabelsOnInteractionOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_HideVertexLabelsOnInteractionOff_67(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_HideVertexLabelsOnInteractionOn_68(HandleRef pThis);

		public virtual void HideVertexLabelsOnInteractionOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_HideVertexLabelsOnInteractionOn_68(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedGraphRepresentation_IsA_69(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_IsA_69(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedGraphRepresentation_IsLayoutComplete_70(HandleRef pThis);

		public virtual bool IsLayoutComplete()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_IsLayoutComplete_70(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedGraphRepresentation_IsTypeOf_71(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_IsTypeOf_71(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_NewInstance_73(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRenderedGraphRepresentation NewInstance()
		{
			vtkRenderedGraphRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_NewInstance_73(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedGraphRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedGraphRepresentation_SafeDownCast_74(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderedGraphRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkRenderedGraphRepresentation vtkRenderedGraphRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SafeDownCast_74((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderedGraphRepresentation = (vtkRenderedGraphRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderedGraphRepresentation.Register(null);
				}
			}
			return vtkRenderedGraphRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_ScalingOff_75(HandleRef pThis);

		public virtual void ScalingOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ScalingOff_75(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_ScalingOn_76(HandleRef pThis);

		public virtual void ScalingOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ScalingOn_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetColorEdgesByArray_77(HandleRef pThis, byte b);

		public virtual void SetColorEdgesByArray(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetColorEdgesByArray_77(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetColorVerticesByArray_78(HandleRef pThis, byte b);

		public virtual void SetColorVerticesByArray(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetColorVerticesByArray_78(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeColorArrayName_79(HandleRef pThis, string name);

		public virtual void SetEdgeColorArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeColorArrayName_79(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeHoverArrayName_80(HandleRef pThis, string _arg);

		public virtual void SetEdgeHoverArrayName(string _arg)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeHoverArrayName_80(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeIconAlignment_81(HandleRef pThis, int align);

		public virtual void SetEdgeIconAlignment(int align)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeIconAlignment_81(base.GetCppThis(), align);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeIconArrayName_82(HandleRef pThis, string name);

		public virtual void SetEdgeIconArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeIconArrayName_82(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeIconPriorityArrayName_83(HandleRef pThis, string name);

		public virtual void SetEdgeIconPriorityArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeIconPriorityArrayName_83(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeIconVisibility_84(HandleRef pThis, byte b);

		public virtual void SetEdgeIconVisibility(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeIconVisibility_84(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLabelArrayName_85(HandleRef pThis, string name);

		public virtual void SetEdgeLabelArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLabelArrayName_85(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLabelPriorityArrayName_86(HandleRef pThis, string name);

		public virtual void SetEdgeLabelPriorityArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLabelPriorityArrayName_86(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLabelTextProperty_87(HandleRef pThis, HandleRef p);

		public virtual void SetEdgeLabelTextProperty(vtkTextProperty p)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLabelTextProperty_87(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLabelVisibility_88(HandleRef pThis, byte b);

		public virtual void SetEdgeLabelVisibility(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLabelVisibility_88(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLayoutStrategy_89(HandleRef pThis, HandleRef strategy);

		public virtual void SetEdgeLayoutStrategy(vtkEdgeLayoutStrategy strategy)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLayoutStrategy_89(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLayoutStrategy_90(HandleRef pThis, string name);

		public virtual void SetEdgeLayoutStrategy(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLayoutStrategy_90(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToArcParallel_91(HandleRef pThis);

		public void SetEdgeLayoutStrategyToArcParallel()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToArcParallel_91(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToGeo_92(HandleRef pThis, double explodeFactor);

		public virtual void SetEdgeLayoutStrategyToGeo(double explodeFactor)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToGeo_92(base.GetCppThis(), explodeFactor);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToPassThrough_93(HandleRef pThis);

		public void SetEdgeLayoutStrategyToPassThrough()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToPassThrough_93(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeScalarBarVisibility_94(HandleRef pThis, byte b);

		public virtual void SetEdgeScalarBarVisibility(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeScalarBarVisibility_94(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeSelection_95(HandleRef pThis, byte b);

		public void SetEdgeSelection(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeSelection_95(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeVisibility_96(HandleRef pThis, byte b);

		public virtual void SetEdgeVisibility(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeVisibility_96(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEnableEdgesByArray_97(HandleRef pThis, byte b);

		public virtual void SetEnableEdgesByArray(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEnableEdgesByArray_97(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEnableVerticesByArray_98(HandleRef pThis, byte b);

		public virtual void SetEnableVerticesByArray(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEnableVerticesByArray_98(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEnabledEdgesArrayName_99(HandleRef pThis, string name);

		public virtual void SetEnabledEdgesArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEnabledEdgesArrayName_99(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetEnabledVerticesArrayName_100(HandleRef pThis, string name);

		public virtual void SetEnabledVerticesArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEnabledVerticesArrayName_100(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetGlyphType_101(HandleRef pThis, int type);

		public virtual void SetGlyphType(int type)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetGlyphType_101(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetHideEdgeLabelsOnInteraction_102(HandleRef pThis, byte _arg);

		public virtual void SetHideEdgeLabelsOnInteraction(bool _arg)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetHideEdgeLabelsOnInteraction_102(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetHideVertexLabelsOnInteraction_103(HandleRef pThis, byte _arg);

		public virtual void SetHideVertexLabelsOnInteraction(bool _arg)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetHideVertexLabelsOnInteraction_103(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategy_104(HandleRef pThis, HandleRef strategy);

		public virtual void SetLayoutStrategy(vtkGraphLayoutStrategy strategy)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategy_104(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategy_105(HandleRef pThis, string name);

		public virtual void SetLayoutStrategy(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategy_105(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToAssignCoordinates_106(HandleRef pThis, string xarr, string yarr, string zarr);

		public virtual void SetLayoutStrategyToAssignCoordinates(string xarr, string yarr, string zarr)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToAssignCoordinates_106(base.GetCppThis(), xarr, yarr, zarr);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToCircular_107(HandleRef pThis);

		public void SetLayoutStrategyToCircular()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToCircular_107(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToClustering2D_108(HandleRef pThis);

		public void SetLayoutStrategyToClustering2D()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToClustering2D_108(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToCommunity2D_109(HandleRef pThis);

		public void SetLayoutStrategyToCommunity2D()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToCommunity2D_109(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToCone_110(HandleRef pThis);

		public void SetLayoutStrategyToCone()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToCone_110(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToCosmicTree_111(HandleRef pThis);

		public void SetLayoutStrategyToCosmicTree()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToCosmicTree_111(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToCosmicTree_112(HandleRef pThis, string nodeSizeArrayName, byte sizeLeafNodesOnly, int layoutDepth, long layoutRoot);

		public virtual void SetLayoutStrategyToCosmicTree(string nodeSizeArrayName, bool sizeLeafNodesOnly, int layoutDepth, long layoutRoot)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToCosmicTree_112(base.GetCppThis(), nodeSizeArrayName, sizeLeafNodesOnly ? (byte)1 : (byte)0, layoutDepth, layoutRoot);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToFast2D_113(HandleRef pThis);

		public void SetLayoutStrategyToFast2D()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToFast2D_113(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToForceDirected_114(HandleRef pThis);

		public void SetLayoutStrategyToForceDirected()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToForceDirected_114(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToPassThrough_115(HandleRef pThis);

		public void SetLayoutStrategyToPassThrough()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToPassThrough_115(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToRandom_116(HandleRef pThis);

		public void SetLayoutStrategyToRandom()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToRandom_116(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToSimple2D_117(HandleRef pThis);

		public void SetLayoutStrategyToSimple2D()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToSimple2D_117(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToSpanTree_118(HandleRef pThis);

		public void SetLayoutStrategyToSpanTree()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToSpanTree_118(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToTree_119(HandleRef pThis);

		public void SetLayoutStrategyToTree()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToTree_119(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToTree_120(HandleRef pThis, byte radial, double angle, double leafSpacing, double logSpacing);

		public virtual void SetLayoutStrategyToTree(bool radial, double angle, double leafSpacing, double logSpacing)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToTree_120(base.GetCppThis(), radial ? (byte)1 : (byte)0, angle, leafSpacing, logSpacing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetScaling_121(HandleRef pThis, byte b);

		public virtual void SetScaling(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetScaling_121(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetScalingArrayName_122(HandleRef pThis, string name);

		public virtual void SetScalingArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetScalingArrayName_122(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetUseEdgeIconTypeMap_123(HandleRef pThis, byte b);

		public virtual void SetUseEdgeIconTypeMap(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetUseEdgeIconTypeMap_123(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetUseVertexIconTypeMap_124(HandleRef pThis, byte b);

		public virtual void SetUseVertexIconTypeMap(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetUseVertexIconTypeMap_124(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexColorArrayName_125(HandleRef pThis, string name);

		public virtual void SetVertexColorArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexColorArrayName_125(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexDefaultIcon_126(HandleRef pThis, int icon);

		public virtual void SetVertexDefaultIcon(int icon)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexDefaultIcon_126(base.GetCppThis(), icon);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexHoverArrayName_127(HandleRef pThis, string _arg);

		public virtual void SetVertexHoverArrayName(string _arg)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexHoverArrayName_127(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconAlignment_128(HandleRef pThis, int align);

		public virtual void SetVertexIconAlignment(int align)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconAlignment_128(base.GetCppThis(), align);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconArrayName_129(HandleRef pThis, string name);

		public virtual void SetVertexIconArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconArrayName_129(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconPriorityArrayName_130(HandleRef pThis, string name);

		public virtual void SetVertexIconPriorityArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconPriorityArrayName_130(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconSelectionMode_131(HandleRef pThis, int mode);

		public virtual void SetVertexIconSelectionMode(int mode)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconSelectionMode_131(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToAnnotationIcon_132(HandleRef pThis);

		public virtual void SetVertexIconSelectionModeToAnnotationIcon()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToAnnotationIcon_132(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToIgnoreSelection_133(HandleRef pThis);

		public virtual void SetVertexIconSelectionModeToIgnoreSelection()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToIgnoreSelection_133(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToSelectedIcon_134(HandleRef pThis);

		public virtual void SetVertexIconSelectionModeToSelectedIcon()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToSelectedIcon_134(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToSelectedOffset_135(HandleRef pThis);

		public virtual void SetVertexIconSelectionModeToSelectedOffset()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToSelectedOffset_135(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconVisibility_136(HandleRef pThis, byte b);

		public virtual void SetVertexIconVisibility(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconVisibility_136(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexLabelArrayName_137(HandleRef pThis, string name);

		public virtual void SetVertexLabelArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexLabelArrayName_137(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexLabelPriorityArrayName_138(HandleRef pThis, string name);

		public virtual void SetVertexLabelPriorityArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexLabelPriorityArrayName_138(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexLabelTextProperty_139(HandleRef pThis, HandleRef p);

		public virtual void SetVertexLabelTextProperty(vtkTextProperty p)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexLabelTextProperty_139(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexLabelVisibility_140(HandleRef pThis, byte b);

		public virtual void SetVertexLabelVisibility(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexLabelVisibility_140(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexScalarBarVisibility_141(HandleRef pThis, byte b);

		public virtual void SetVertexScalarBarVisibility(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexScalarBarVisibility_141(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexSelectedIcon_142(HandleRef pThis, int icon);

		public virtual void SetVertexSelectedIcon(int icon)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexSelectedIcon_142(base.GetCppThis(), icon);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_UpdateLayout_143(HandleRef pThis);

		public virtual void UpdateLayout()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_UpdateLayout_143(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_UseEdgeIconTypeMapOff_144(HandleRef pThis);

		public virtual void UseEdgeIconTypeMapOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_UseEdgeIconTypeMapOff_144(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_UseEdgeIconTypeMapOn_145(HandleRef pThis);

		public virtual void UseEdgeIconTypeMapOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_UseEdgeIconTypeMapOn_145(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_UseVertexIconTypeMapOff_146(HandleRef pThis);

		public virtual void UseVertexIconTypeMapOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_UseVertexIconTypeMapOff_146(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_UseVertexIconTypeMapOn_147(HandleRef pThis);

		public virtual void UseVertexIconTypeMapOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_UseVertexIconTypeMapOn_147(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_VertexIconVisibilityOff_148(HandleRef pThis);

		public virtual void VertexIconVisibilityOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_VertexIconVisibilityOff_148(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_VertexIconVisibilityOn_149(HandleRef pThis);

		public virtual void VertexIconVisibilityOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_VertexIconVisibilityOn_149(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_VertexLabelVisibilityOff_150(HandleRef pThis);

		public virtual void VertexLabelVisibilityOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_VertexLabelVisibilityOff_150(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedGraphRepresentation_VertexLabelVisibilityOn_151(HandleRef pThis);

		public virtual void VertexLabelVisibilityOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_VertexLabelVisibilityOn_151(base.GetCppThis());
		}
	}
}
