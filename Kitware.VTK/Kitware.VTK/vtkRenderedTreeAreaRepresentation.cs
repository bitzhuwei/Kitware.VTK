using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRenderedTreeAreaRepresentation : vtkRenderedRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderedTreeAreaRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkRenderedTreeAreaRepresentation()
		{
			vtkRenderedTreeAreaRepresentation.MRClassNameKey = "class vtkRenderedTreeAreaRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderedTreeAreaRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderedTreeAreaRepresentation"));
		}

		public vtkRenderedTreeAreaRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderedTreeAreaRepresentation New()
		{
			vtkRenderedTreeAreaRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedTreeAreaRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRenderedTreeAreaRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_ApplyViewTheme_01(HandleRef pThis, HandleRef theme);

		public override void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_ApplyViewTheme_01(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_AreaLabelVisibilityOff_02(HandleRef pThis);

		public virtual void AreaLabelVisibilityOff()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_AreaLabelVisibilityOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_AreaLabelVisibilityOn_03(HandleRef pThis);

		public virtual void AreaLabelVisibilityOn()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_AreaLabelVisibilityOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_ColorAreasByArrayOff_04(HandleRef pThis);

		public virtual void ColorAreasByArrayOff()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_ColorAreasByArrayOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_ColorAreasByArrayOn_05(HandleRef pThis);

		public virtual void ColorAreasByArrayOn()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_ColorAreasByArrayOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_ColorGraphEdgesByArrayOff_06(HandleRef pThis);

		public virtual void ColorGraphEdgesByArrayOff()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_ColorGraphEdgesByArrayOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_ColorGraphEdgesByArrayOn_07(HandleRef pThis);

		public virtual void ColorGraphEdgesByArrayOn()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_ColorGraphEdgesByArrayOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaColorArrayName_08(HandleRef pThis);

		public string GetAreaColorArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaColorArrayName_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaHoverArrayName_09(HandleRef pThis);

		public virtual string GetAreaHoverArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaHoverArrayName_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaLabelArrayName_10(HandleRef pThis);

		public virtual string GetAreaLabelArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaLabelArrayName_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaLabelMapper_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLabeledDataMapper GetAreaLabelMapper()
		{
			vtkLabeledDataMapper vtkLabeledDataMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaLabelMapper_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabeledDataMapper = (vtkLabeledDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabeledDataMapper.Register(null);
				}
			}
			return vtkLabeledDataMapper;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaLabelPriorityArrayName_12(HandleRef pThis);

		public virtual string GetAreaLabelPriorityArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaLabelPriorityArrayName_12(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaLabelTextProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetAreaLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaLabelTextProperty_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern byte vtkRenderedTreeAreaRepresentation_GetAreaLabelVisibility_14(HandleRef pThis);

		public virtual bool GetAreaLabelVisibility()
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaLabelVisibility_14(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaLayoutStrategy_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAreaLayoutStrategy GetAreaLayoutStrategy()
		{
			vtkAreaLayoutStrategy vtkAreaLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaLayoutStrategy_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaSizeArrayName_16(HandleRef pThis);

		public virtual string GetAreaSizeArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaSizeArrayName_16(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaToPolyData_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPolyDataAlgorithm GetAreaToPolyData()
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaToPolyData_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedTreeAreaRepresentation_GetColorAreasByArray_18(HandleRef pThis);

		public virtual bool GetColorAreasByArray()
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetColorAreasByArray_18(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedTreeAreaRepresentation_GetColorGraphEdgesByArray_19(HandleRef pThis);

		public virtual bool GetColorGraphEdgesByArray()
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetColorGraphEdgesByArray_19(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedTreeAreaRepresentation_GetColorGraphEdgesByArray_20(HandleRef pThis, int idx);

		public virtual bool GetColorGraphEdgesByArray(int idx)
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetColorGraphEdgesByArray_20(base.GetCppThis(), idx) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedTreeAreaRepresentation_GetEdgeScalarBarVisibility_21(HandleRef pThis);

		public virtual bool GetEdgeScalarBarVisibility()
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetEdgeScalarBarVisibility_21(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkRenderedTreeAreaRepresentation_GetGraphBundlingStrength_22(HandleRef pThis);

		public virtual double GetGraphBundlingStrength()
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphBundlingStrength_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkRenderedTreeAreaRepresentation_GetGraphBundlingStrength_23(HandleRef pThis, int idx);

		public virtual double GetGraphBundlingStrength(int idx)
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphBundlingStrength_23(base.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeColorArrayName_24(HandleRef pThis);

		public virtual string GetGraphEdgeColorArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphEdgeColorArrayName_24(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeColorArrayName_25(HandleRef pThis, int idx);

		public virtual string GetGraphEdgeColorArrayName(int idx)
		{
			return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphEdgeColorArrayName_25(base.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelArrayName_26(HandleRef pThis);

		public virtual string GetGraphEdgeLabelArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelArrayName_26(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelArrayName_27(HandleRef pThis, int idx);

		public virtual string GetGraphEdgeLabelArrayName(int idx)
		{
			return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelArrayName_27(base.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelTextProperty_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetGraphEdgeLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelTextProperty_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelTextProperty_29(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetGraphEdgeLabelTextProperty(int idx)
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelTextProperty_29(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern byte vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelVisibility_30(HandleRef pThis);

		public virtual bool GetGraphEdgeLabelVisibility()
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelVisibility_30(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelVisibility_31(HandleRef pThis, int idx);

		public virtual bool GetGraphEdgeLabelVisibility(int idx)
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelVisibility_31(base.GetCppThis(), idx) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphHoverArrayName_32(HandleRef pThis, int idx);

		public virtual string GetGraphHoverArrayName(int idx)
		{
			return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphHoverArrayName_32(base.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphHoverArrayName_33(HandleRef pThis);

		public virtual string GetGraphHoverArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphHoverArrayName_33(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedTreeAreaRepresentation_GetGraphSplineType_34(HandleRef pThis, int idx);

		public virtual int GetGraphSplineType(int idx)
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphSplineType_34(base.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkRenderedTreeAreaRepresentation_GetShrinkPercentage_35(HandleRef pThis);

		public virtual double GetShrinkPercentage()
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetShrinkPercentage_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedTreeAreaRepresentation_GetUseRectangularCoordinates_36(HandleRef pThis);

		public virtual bool GetUseRectangularCoordinates()
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetUseRectangularCoordinates_36(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_GraphEdgeLabelVisibilityOff_37(HandleRef pThis);

		public virtual void GraphEdgeLabelVisibilityOff()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GraphEdgeLabelVisibilityOff_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_GraphEdgeLabelVisibilityOn_38(HandleRef pThis);

		public virtual void GraphEdgeLabelVisibilityOn()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GraphEdgeLabelVisibilityOn_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedTreeAreaRepresentation_IsA_39(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_IsA_39(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedTreeAreaRepresentation_IsTypeOf_40(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_IsTypeOf_40(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_NewInstance_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRenderedTreeAreaRepresentation NewInstance()
		{
			vtkRenderedTreeAreaRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_NewInstance_42(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedTreeAreaRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderedTreeAreaRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkRenderedTreeAreaRepresentation vtkRenderedTreeAreaRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SafeDownCast_43((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderedTreeAreaRepresentation = (vtkRenderedTreeAreaRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderedTreeAreaRepresentation.Register(null);
				}
			}
			return vtkRenderedTreeAreaRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaColorArrayName_44(HandleRef pThis, string name);

		public void SetAreaColorArrayName(string name)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaColorArrayName_44(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaHoverArrayName_45(HandleRef pThis, string _arg);

		public virtual void SetAreaHoverArrayName(string _arg)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaHoverArrayName_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLabelArrayName_46(HandleRef pThis, string name);

		public virtual void SetAreaLabelArrayName(string name)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaLabelArrayName_46(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLabelMapper_47(HandleRef pThis, HandleRef mapper);

		public virtual void SetAreaLabelMapper(vtkLabeledDataMapper mapper)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaLabelMapper_47(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLabelPriorityArrayName_48(HandleRef pThis, string name);

		public virtual void SetAreaLabelPriorityArrayName(string name)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaLabelPriorityArrayName_48(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLabelTextProperty_49(HandleRef pThis, HandleRef tp);

		public virtual void SetAreaLabelTextProperty(vtkTextProperty tp)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaLabelTextProperty_49(base.GetCppThis(), (tp == null) ? default(HandleRef) : tp.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLabelVisibility_50(HandleRef pThis, byte vis);

		public virtual void SetAreaLabelVisibility(bool vis)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaLabelVisibility_50(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLayoutStrategy_51(HandleRef pThis, HandleRef strategy);

		public virtual void SetAreaLayoutStrategy(vtkAreaLayoutStrategy strategy)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaLayoutStrategy_51(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaSizeArrayName_52(HandleRef pThis, string name);

		public virtual void SetAreaSizeArrayName(string name)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaSizeArrayName_52(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaToPolyData_53(HandleRef pThis, HandleRef areaToPoly);

		public virtual void SetAreaToPolyData(vtkPolyDataAlgorithm areaToPoly)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaToPolyData_53(base.GetCppThis(), (areaToPoly == null) ? default(HandleRef) : areaToPoly.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetColorAreasByArray_54(HandleRef pThis, byte vis);

		public virtual void SetColorAreasByArray(bool vis)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetColorAreasByArray_54(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetColorGraphEdgesByArray_55(HandleRef pThis, byte vis);

		public virtual void SetColorGraphEdgesByArray(bool vis)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetColorGraphEdgesByArray_55(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetColorGraphEdgesByArray_56(HandleRef pThis, byte vis, int idx);

		public virtual void SetColorGraphEdgesByArray(bool vis, int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetColorGraphEdgesByArray_56(base.GetCppThis(), vis ? (byte)1 : (byte)0, idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetEdgeScalarBarVisibility_57(HandleRef pThis, byte b);

		public virtual void SetEdgeScalarBarVisibility(bool b)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetEdgeScalarBarVisibility_57(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphBundlingStrength_58(HandleRef pThis, double strength);

		public virtual void SetGraphBundlingStrength(double strength)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphBundlingStrength_58(base.GetCppThis(), strength);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphBundlingStrength_59(HandleRef pThis, double strength, int idx);

		public virtual void SetGraphBundlingStrength(double strength, int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphBundlingStrength_59(base.GetCppThis(), strength, idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorArrayName_60(HandleRef pThis, string name);

		public virtual void SetGraphEdgeColorArrayName(string name)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorArrayName_60(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorArrayName_61(HandleRef pThis, string name, int idx);

		public virtual void SetGraphEdgeColorArrayName(string name, int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorArrayName_61(base.GetCppThis(), name, idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorToSplineFraction_62(HandleRef pThis);

		public virtual void SetGraphEdgeColorToSplineFraction()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorToSplineFraction_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorToSplineFraction_63(HandleRef pThis, int idx);

		public virtual void SetGraphEdgeColorToSplineFraction(int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorToSplineFraction_63(base.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelArrayName_64(HandleRef pThis, string name);

		public virtual void SetGraphEdgeLabelArrayName(string name)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelArrayName_64(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelArrayName_65(HandleRef pThis, string name, int idx);

		public virtual void SetGraphEdgeLabelArrayName(string name, int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelArrayName_65(base.GetCppThis(), name, idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelTextProperty_66(HandleRef pThis, HandleRef tp);

		public virtual void SetGraphEdgeLabelTextProperty(vtkTextProperty tp)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelTextProperty_66(base.GetCppThis(), (tp == null) ? default(HandleRef) : tp.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelTextProperty_67(HandleRef pThis, HandleRef tp, int idx);

		public virtual void SetGraphEdgeLabelTextProperty(vtkTextProperty tp, int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelTextProperty_67(base.GetCppThis(), (tp == null) ? default(HandleRef) : tp.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelVisibility_68(HandleRef pThis, byte vis);

		public virtual void SetGraphEdgeLabelVisibility(bool vis)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelVisibility_68(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelVisibility_69(HandleRef pThis, byte vis, int idx);

		public virtual void SetGraphEdgeLabelVisibility(bool vis, int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelVisibility_69(base.GetCppThis(), vis ? (byte)1 : (byte)0, idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphHoverArrayName_70(HandleRef pThis, string name);

		public virtual void SetGraphHoverArrayName(string name)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphHoverArrayName_70(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphHoverArrayName_71(HandleRef pThis, string name, int idx);

		public virtual void SetGraphHoverArrayName(string name, int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphHoverArrayName_71(base.GetCppThis(), name, idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphSplineType_72(HandleRef pThis, int type, int idx);

		public virtual void SetGraphSplineType(int type, int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphSplineType_72(base.GetCppThis(), type, idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetLabelRenderMode_73(HandleRef pThis, int mode);

		public override void SetLabelRenderMode(int mode)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetLabelRenderMode_73(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetShrinkPercentage_74(HandleRef pThis, double value);

		public virtual void SetShrinkPercentage(double value)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetShrinkPercentage_74(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetUseRectangularCoordinates_75(HandleRef pThis, byte _arg);

		public virtual void SetUseRectangularCoordinates(bool _arg)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetUseRectangularCoordinates_75(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_UseRectangularCoordinatesOff_76(HandleRef pThis);

		public virtual void UseRectangularCoordinatesOff()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_UseRectangularCoordinatesOff_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedTreeAreaRepresentation_UseRectangularCoordinatesOn_77(HandleRef pThis);

		public virtual void UseRectangularCoordinatesOn()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_UseRectangularCoordinatesOn_77(base.GetCppThis());
		}
	}
}
