using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHierarchicalGraphPipeline : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalGraphPipeline";

		public new static readonly string MRClassNameKey;

		static vtkHierarchicalGraphPipeline()
		{
			vtkHierarchicalGraphPipeline.MRClassNameKey = "class vtkHierarchicalGraphPipeline";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalGraphPipeline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalGraphPipeline"));
		}

		public vtkHierarchicalGraphPipeline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalGraphPipeline New()
		{
			vtkHierarchicalGraphPipeline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalGraphPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHierarchicalGraphPipeline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_ApplyViewTheme_01(HandleRef pThis, HandleRef theme);

		public virtual void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_ApplyViewTheme_01(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_ColorEdgesByArrayOff_02(HandleRef pThis);

		public virtual void ColorEdgesByArrayOff()
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_ColorEdgesByArrayOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_ColorEdgesByArrayOn_03(HandleRef pThis);

		public virtual void ColorEdgesByArrayOn()
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_ColorEdgesByArrayOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_ConvertSelection_04(HandleRef pThis, HandleRef rep, HandleRef sel, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSelection ConvertSelection(vtkDataRepresentation rep, vtkSelection sel)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_ConvertSelection_04(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), (sel == null) ? default(HandleRef) : sel.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_GetActor_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkActor GetActor()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetActor_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkHierarchicalGraphPipeline_GetBundlingStrength_06(HandleRef pThis);

		public virtual double GetBundlingStrength()
		{
			return vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetBundlingStrength_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_GetColorArrayName_07(HandleRef pThis);

		public virtual string GetColorArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetColorArrayName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkHierarchicalGraphPipeline_GetColorEdgesByArray_08(HandleRef pThis);

		public virtual bool GetColorEdgesByArray()
		{
			return vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetColorEdgesByArray_08(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_GetHoverArrayName_09(HandleRef pThis);

		public virtual string GetHoverArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetHoverArrayName_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_GetLabelActor_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkActor2D GetLabelActor()
		{
			vtkActor2D vtkActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetLabelActor_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor2D = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor2D.Register(null);
				}
			}
			return vtkActor2D;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_GetLabelArrayName_11(HandleRef pThis);

		public virtual string GetLabelArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetLabelArrayName_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_GetLabelTextProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetLabelTextProperty_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern byte vtkHierarchicalGraphPipeline_GetLabelVisibility_13(HandleRef pThis);

		public virtual bool GetLabelVisibility()
		{
			return vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetLabelVisibility_13(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkHierarchicalGraphPipeline_GetSplineType_14(HandleRef pThis);

		public virtual int GetSplineType()
		{
			return vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetSplineType_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkHierarchicalGraphPipeline_GetVisibility_15(HandleRef pThis);

		public virtual bool GetVisibility()
		{
			return vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetVisibility_15(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkHierarchicalGraphPipeline_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkHierarchicalGraphPipeline_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_LabelVisibilityOff_18(HandleRef pThis);

		public virtual void LabelVisibilityOff()
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_LabelVisibilityOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_LabelVisibilityOn_19(HandleRef pThis);

		public virtual void LabelVisibilityOn()
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_LabelVisibilityOn_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHierarchicalGraphPipeline NewInstance()
		{
			vtkHierarchicalGraphPipeline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalGraphPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_PrepareInputConnections_22(HandleRef pThis, HandleRef graphConn, HandleRef treeConn, HandleRef annConn);

		public virtual void PrepareInputConnections(vtkAlgorithmOutput graphConn, vtkAlgorithmOutput treeConn, vtkAlgorithmOutput annConn)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_PrepareInputConnections_22(base.GetCppThis(), (graphConn == null) ? default(HandleRef) : graphConn.GetCppThis(), (treeConn == null) ? default(HandleRef) : treeConn.GetCppThis(), (annConn == null) ? default(HandleRef) : annConn.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_RegisterProgress_23(HandleRef pThis, HandleRef view);

		public void RegisterProgress(vtkRenderView view)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_RegisterProgress_23(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalGraphPipeline SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalGraphPipeline vtkHierarchicalGraphPipeline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalGraphPipeline = (vtkHierarchicalGraphPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalGraphPipeline.Register(null);
				}
			}
			return vtkHierarchicalGraphPipeline;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_SetBundlingStrength_25(HandleRef pThis, double strength);

		public virtual void SetBundlingStrength(double strength)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetBundlingStrength_25(base.GetCppThis(), strength);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_SetColorArrayName_26(HandleRef pThis, string name);

		public virtual void SetColorArrayName(string name)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetColorArrayName_26(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_SetColorEdgesByArray_27(HandleRef pThis, byte vis);

		public virtual void SetColorEdgesByArray(bool vis)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetColorEdgesByArray_27(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_SetHoverArrayName_28(HandleRef pThis, string _arg);

		public virtual void SetHoverArrayName(string _arg)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetHoverArrayName_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_SetLabelArrayName_29(HandleRef pThis, string name);

		public virtual void SetLabelArrayName(string name)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetLabelArrayName_29(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_SetLabelTextProperty_30(HandleRef pThis, HandleRef prop);

		public virtual void SetLabelTextProperty(vtkTextProperty prop)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetLabelTextProperty_30(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_SetLabelVisibility_31(HandleRef pThis, byte vis);

		public virtual void SetLabelVisibility(bool vis)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetLabelVisibility_31(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_SetSplineType_32(HandleRef pThis, int type);

		public virtual void SetSplineType(int type)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetSplineType_32(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_SetVisibility_33(HandleRef pThis, byte vis);

		public virtual void SetVisibility(bool vis)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetVisibility_33(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_VisibilityOff_34(HandleRef pThis);

		public virtual void VisibilityOff()
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_VisibilityOff_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphPipeline_VisibilityOn_35(HandleRef pThis);

		public virtual void VisibilityOn()
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_VisibilityOn_35(base.GetCppThis());
		}
	}
}
