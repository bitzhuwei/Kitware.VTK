using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRenderedHierarchyRepresentation : vtkRenderedGraphRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderedHierarchyRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkRenderedHierarchyRepresentation()
		{
			vtkRenderedHierarchyRepresentation.MRClassNameKey = "class vtkRenderedHierarchyRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderedHierarchyRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderedHierarchyRepresentation"));
		}

		public vtkRenderedHierarchyRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedHierarchyRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderedHierarchyRepresentation New()
		{
			vtkRenderedHierarchyRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedHierarchyRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRenderedHierarchyRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_ColorGraphEdgesByArrayOff_01(HandleRef pThis);

		public virtual void ColorGraphEdgesByArrayOff()
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_ColorGraphEdgesByArrayOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_ColorGraphEdgesByArrayOn_02(HandleRef pThis);

		public virtual void ColorGraphEdgesByArrayOn()
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_ColorGraphEdgesByArrayOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkRenderedHierarchyRepresentation_GetBundlingStrength_03(HandleRef pThis);

		public virtual double GetBundlingStrength()
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetBundlingStrength_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkRenderedHierarchyRepresentation_GetBundlingStrength_04(HandleRef pThis, int idx);

		public virtual double GetBundlingStrength(int idx)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetBundlingStrength_04(base.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedHierarchyRepresentation_GetColorGraphEdgesByArray_05(HandleRef pThis);

		public virtual bool GetColorGraphEdgesByArray()
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetColorGraphEdgesByArray_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedHierarchyRepresentation_GetColorGraphEdgesByArray_06(HandleRef pThis, int idx);

		public virtual bool GetColorGraphEdgesByArray(int idx)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetColorGraphEdgesByArray_06(base.GetCppThis(), idx) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedHierarchyRepresentation_GetGraphEdgeColorArrayName_07(HandleRef pThis);

		public virtual string GetGraphEdgeColorArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphEdgeColorArrayName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedHierarchyRepresentation_GetGraphEdgeColorArrayName_08(HandleRef pThis, int idx);

		public virtual string GetGraphEdgeColorArrayName(int idx)
		{
			return Marshal.PtrToStringAnsi(vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphEdgeColorArrayName_08(base.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelArrayName_09(HandleRef pThis);

		public virtual string GetGraphEdgeLabelArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelArrayName_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelArrayName_10(HandleRef pThis, int idx);

		public virtual string GetGraphEdgeLabelArrayName(int idx)
		{
			return Marshal.PtrToStringAnsi(vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelArrayName_10(base.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelFontSize_11(HandleRef pThis);

		public virtual int GetGraphEdgeLabelFontSize()
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelFontSize_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelFontSize_12(HandleRef pThis, int idx);

		public virtual int GetGraphEdgeLabelFontSize(int idx)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelFontSize_12(base.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelVisibility_13(HandleRef pThis);

		public virtual bool GetGraphEdgeLabelVisibility()
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelVisibility_13(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelVisibility_14(HandleRef pThis, int idx);

		public virtual bool GetGraphEdgeLabelVisibility(int idx)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelVisibility_14(base.GetCppThis(), idx) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedHierarchyRepresentation_GetGraphSplineType_15(HandleRef pThis, int idx);

		public virtual int GetGraphSplineType(int idx)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphSplineType_15(base.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedHierarchyRepresentation_GetGraphVisibility_16(HandleRef pThis);

		public virtual bool GetGraphVisibility()
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphVisibility_16(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderedHierarchyRepresentation_GetGraphVisibility_17(HandleRef pThis, int idx);

		public virtual bool GetGraphVisibility(int idx)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphVisibility_17(base.GetCppThis(), idx) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_GraphEdgeLabelVisibilityOff_18(HandleRef pThis);

		public virtual void GraphEdgeLabelVisibilityOff()
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GraphEdgeLabelVisibilityOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_GraphEdgeLabelVisibilityOn_19(HandleRef pThis);

		public virtual void GraphEdgeLabelVisibilityOn()
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GraphEdgeLabelVisibilityOn_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_GraphVisibilityOff_20(HandleRef pThis);

		public virtual void GraphVisibilityOff()
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GraphVisibilityOff_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_GraphVisibilityOn_21(HandleRef pThis);

		public virtual void GraphVisibilityOn()
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GraphVisibilityOn_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedHierarchyRepresentation_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedHierarchyRepresentation_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedHierarchyRepresentation_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRenderedHierarchyRepresentation NewInstance()
		{
			vtkRenderedHierarchyRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedHierarchyRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedHierarchyRepresentation_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderedHierarchyRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkRenderedHierarchyRepresentation vtkRenderedHierarchyRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderedHierarchyRepresentation = (vtkRenderedHierarchyRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderedHierarchyRepresentation.Register(null);
				}
			}
			return vtkRenderedHierarchyRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetBundlingStrength_27(HandleRef pThis, double strength);

		public virtual void SetBundlingStrength(double strength)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetBundlingStrength_27(base.GetCppThis(), strength);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetBundlingStrength_28(HandleRef pThis, double strength, int idx);

		public virtual void SetBundlingStrength(double strength, int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetBundlingStrength_28(base.GetCppThis(), strength, idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetColorGraphEdgesByArray_29(HandleRef pThis, byte vis);

		public virtual void SetColorGraphEdgesByArray(bool vis)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetColorGraphEdgesByArray_29(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetColorGraphEdgesByArray_30(HandleRef pThis, byte vis, int idx);

		public virtual void SetColorGraphEdgesByArray(bool vis, int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetColorGraphEdgesByArray_30(base.GetCppThis(), vis ? (byte)1 : (byte)0, idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeColorArrayName_31(HandleRef pThis, string name);

		public virtual void SetGraphEdgeColorArrayName(string name)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeColorArrayName_31(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeColorArrayName_32(HandleRef pThis, string name, int idx);

		public virtual void SetGraphEdgeColorArrayName(string name, int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeColorArrayName_32(base.GetCppThis(), name, idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeColorToSplineFraction_33(HandleRef pThis);

		public virtual void SetGraphEdgeColorToSplineFraction()
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeColorToSplineFraction_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeColorToSplineFraction_34(HandleRef pThis, int idx);

		public virtual void SetGraphEdgeColorToSplineFraction(int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeColorToSplineFraction_34(base.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelArrayName_35(HandleRef pThis, string name);

		public virtual void SetGraphEdgeLabelArrayName(string name)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelArrayName_35(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelArrayName_36(HandleRef pThis, string name, int idx);

		public virtual void SetGraphEdgeLabelArrayName(string name, int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelArrayName_36(base.GetCppThis(), name, idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelFontSize_37(HandleRef pThis, int size);

		public virtual void SetGraphEdgeLabelFontSize(int size)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelFontSize_37(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelFontSize_38(HandleRef pThis, int size, int idx);

		public virtual void SetGraphEdgeLabelFontSize(int size, int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelFontSize_38(base.GetCppThis(), size, idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelVisibility_39(HandleRef pThis, byte vis);

		public virtual void SetGraphEdgeLabelVisibility(bool vis)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelVisibility_39(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelVisibility_40(HandleRef pThis, byte vis, int idx);

		public virtual void SetGraphEdgeLabelVisibility(bool vis, int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelVisibility_40(base.GetCppThis(), vis ? (byte)1 : (byte)0, idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphSplineType_41(HandleRef pThis, int type, int idx);

		public virtual void SetGraphSplineType(int type, int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphSplineType_41(base.GetCppThis(), type, idx);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphVisibility_42(HandleRef pThis, byte vis);

		public virtual void SetGraphVisibility(bool vis)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphVisibility_42(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphVisibility_43(HandleRef pThis, byte vis, int idx);

		public virtual void SetGraphVisibility(bool vis, int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphVisibility_43(base.GetCppThis(), vis ? (byte)1 : (byte)0, idx);
		}
	}
}
