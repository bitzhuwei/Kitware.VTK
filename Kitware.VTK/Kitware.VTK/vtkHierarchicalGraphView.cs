using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHierarchicalGraphView : vtkGraphLayoutView
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalGraphView";

		public new static readonly string MRClassNameKey;

		static vtkHierarchicalGraphView()
		{
			vtkHierarchicalGraphView.MRClassNameKey = "class vtkHierarchicalGraphView";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalGraphView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalGraphView"));
		}

		public vtkHierarchicalGraphView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalGraphView New()
		{
			vtkHierarchicalGraphView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalGraphView.vtkHierarchicalGraphView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalGraphView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHierarchicalGraphView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHierarchicalGraphView.vtkHierarchicalGraphView_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphView_ColorGraphEdgesByArrayOff_01(HandleRef pThis);

		public virtual void ColorGraphEdgesByArrayOff()
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_ColorGraphEdgesByArrayOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphView_ColorGraphEdgesByArrayOn_02(HandleRef pThis);

		public virtual void ColorGraphEdgesByArrayOn()
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_ColorGraphEdgesByArrayOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkHierarchicalGraphView_GetBundlingStrength_03(HandleRef pThis);

		public virtual double GetBundlingStrength()
		{
			return vtkHierarchicalGraphView.vtkHierarchicalGraphView_GetBundlingStrength_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkHierarchicalGraphView_GetColorGraphEdgesByArray_04(HandleRef pThis);

		public virtual bool GetColorGraphEdgesByArray()
		{
			return vtkHierarchicalGraphView.vtkHierarchicalGraphView_GetColorGraphEdgesByArray_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphView_GetGraphEdgeColorArrayName_05(HandleRef pThis);

		public virtual string GetGraphEdgeColorArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkHierarchicalGraphView.vtkHierarchicalGraphView_GetGraphEdgeColorArrayName_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphView_GetGraphEdgeLabelArrayName_06(HandleRef pThis);

		public virtual string GetGraphEdgeLabelArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkHierarchicalGraphView.vtkHierarchicalGraphView_GetGraphEdgeLabelArrayName_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkHierarchicalGraphView_GetGraphEdgeLabelFontSize_07(HandleRef pThis);

		public virtual int GetGraphEdgeLabelFontSize()
		{
			return vtkHierarchicalGraphView.vtkHierarchicalGraphView_GetGraphEdgeLabelFontSize_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkHierarchicalGraphView_GetGraphEdgeLabelVisibility_08(HandleRef pThis);

		public virtual bool GetGraphEdgeLabelVisibility()
		{
			return vtkHierarchicalGraphView.vtkHierarchicalGraphView_GetGraphEdgeLabelVisibility_08(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkHierarchicalGraphView_GetGraphVisibility_09(HandleRef pThis);

		public virtual bool GetGraphVisibility()
		{
			return vtkHierarchicalGraphView.vtkHierarchicalGraphView_GetGraphVisibility_09(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphView_GraphEdgeLabelVisibilityOff_10(HandleRef pThis);

		public virtual void GraphEdgeLabelVisibilityOff()
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_GraphEdgeLabelVisibilityOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphView_GraphEdgeLabelVisibilityOn_11(HandleRef pThis);

		public virtual void GraphEdgeLabelVisibilityOn()
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_GraphEdgeLabelVisibilityOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphView_GraphVisibilityOff_12(HandleRef pThis);

		public virtual void GraphVisibilityOff()
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_GraphVisibilityOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphView_GraphVisibilityOn_13(HandleRef pThis);

		public virtual void GraphVisibilityOn()
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_GraphVisibilityOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkHierarchicalGraphView_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHierarchicalGraphView.vtkHierarchicalGraphView_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkHierarchicalGraphView_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalGraphView.vtkHierarchicalGraphView_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphView_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHierarchicalGraphView NewInstance()
		{
			vtkHierarchicalGraphView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalGraphView.vtkHierarchicalGraphView_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalGraphView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphView_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalGraphView SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalGraphView vtkHierarchicalGraphView = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalGraphView.vtkHierarchicalGraphView_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalGraphView = (vtkHierarchicalGraphView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalGraphView.Register(null);
				}
			}
			return vtkHierarchicalGraphView;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphView_SetBundlingStrength_19(HandleRef pThis, double strength);

		public virtual void SetBundlingStrength(double strength)
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetBundlingStrength_19(base.GetCppThis(), strength);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphView_SetColorGraphEdgesByArray_20(HandleRef pThis, byte vis);

		public virtual void SetColorGraphEdgesByArray(bool vis)
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetColorGraphEdgesByArray_20(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphView_SetGraphEdgeColorArrayName_21(HandleRef pThis, string name);

		public virtual void SetGraphEdgeColorArrayName(string name)
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetGraphEdgeColorArrayName_21(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphView_SetGraphEdgeColorToSplineFraction_22(HandleRef pThis);

		public virtual void SetGraphEdgeColorToSplineFraction()
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetGraphEdgeColorToSplineFraction_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphView_SetGraphEdgeLabelArrayName_23(HandleRef pThis, string name);

		public virtual void SetGraphEdgeLabelArrayName(string name)
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetGraphEdgeLabelArrayName_23(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphView_SetGraphEdgeLabelFontSize_24(HandleRef pThis, int size);

		public virtual void SetGraphEdgeLabelFontSize(int size)
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetGraphEdgeLabelFontSize_24(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkHierarchicalGraphView_SetGraphEdgeLabelVisibility_25(HandleRef pThis, byte vis);

		public virtual void SetGraphEdgeLabelVisibility(bool vis)
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetGraphEdgeLabelVisibility_25(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphView_SetGraphFromInput_26(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataRepresentation SetGraphFromInput(vtkDataObject input)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetGraphFromInput_26(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkHierarchicalGraphView_SetGraphFromInputConnection_27(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataRepresentation SetGraphFromInputConnection(vtkAlgorithmOutput conn)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetGraphFromInputConnection_27(base.GetCppThis(), (conn == null) ? default(HandleRef) : conn.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkHierarchicalGraphView_SetGraphVisibility_28(HandleRef pThis, byte b);

		public virtual void SetGraphVisibility(bool b)
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetGraphVisibility_28(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalGraphView_SetHierarchyFromInput_29(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataRepresentation SetHierarchyFromInput(vtkDataObject input)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetHierarchyFromInput_29(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkHierarchicalGraphView_SetHierarchyFromInputConnection_30(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataRepresentation SetHierarchyFromInputConnection(vtkAlgorithmOutput conn)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetHierarchyFromInputConnection_30(base.GetCppThis(), (conn == null) ? default(HandleRef) : conn.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	}
}
