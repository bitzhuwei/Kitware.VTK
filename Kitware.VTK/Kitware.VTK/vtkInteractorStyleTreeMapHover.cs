using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleTreeMapHover : vtkInteractorStyleImage
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleTreeMapHover";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleTreeMapHover()
		{
			vtkInteractorStyleTreeMapHover.MRClassNameKey = "class vtkInteractorStyleTreeMapHover";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleTreeMapHover.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleTreeMapHover"));
		}

		public vtkInteractorStyleTreeMapHover(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTreeMapHover_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleTreeMapHover New()
		{
			vtkInteractorStyleTreeMapHover result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTreeMapHover)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleTreeMapHover() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkInteractorStyleTreeMapHover_GetHighLightWidth_01(HandleRef pThis);

		public double GetHighLightWidth()
		{
			return vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_GetHighLightWidth_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTreeMapHover_GetLabelField_02(HandleRef pThis);

		public virtual string GetLabelField()
		{
			return Marshal.PtrToStringAnsi(vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_GetLabelField_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTreeMapHover_GetLayout_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTreeMapLayout GetLayout()
		{
			vtkTreeMapLayout vtkTreeMapLayout = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_GetLayout_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeMapLayout = (vtkTreeMapLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeMapLayout.Register(null);
				}
			}
			return vtkTreeMapLayout;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkInteractorStyleTreeMapHover_GetSelectionWidth_04(HandleRef pThis);

		public double GetSelectionWidth()
		{
			return vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_GetSelectionWidth_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTreeMapHover_GetTreeMapToPolyData_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTreeMapToPolyData GetTreeMapToPolyData()
		{
			vtkTreeMapToPolyData vtkTreeMapToPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_GetTreeMapToPolyData_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeMapToPolyData = (vtkTreeMapToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeMapToPolyData.Register(null);
				}
			}
			return vtkTreeMapToPolyData;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTreeMapHover_HighLightCurrentSelectedItem_06(HandleRef pThis);

		public void HighLightCurrentSelectedItem()
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_HighLightCurrentSelectedItem_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTreeMapHover_HighLightItem_07(HandleRef pThis, long id);

		public void HighLightItem(long id)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_HighLightItem_07(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleTreeMapHover_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleTreeMapHover_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTreeMapHover_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleTreeMapHover NewInstance()
		{
			vtkInteractorStyleTreeMapHover result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTreeMapHover)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTreeMapHover_OnLeftButtonUp_12(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_OnLeftButtonUp_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTreeMapHover_OnMouseMove_13(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_OnMouseMove_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTreeMapHover_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleTreeMapHover SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleTreeMapHover vtkInteractorStyleTreeMapHover = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleTreeMapHover = (vtkInteractorStyleTreeMapHover)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleTreeMapHover.Register(null);
				}
			}
			return vtkInteractorStyleTreeMapHover;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTreeMapHover_SetHighLightColor_15(HandleRef pThis, double r, double g, double b);

		public void SetHighLightColor(double r, double g, double b)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SetHighLightColor_15(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTreeMapHover_SetHighLightWidth_16(HandleRef pThis, double lw);

		public void SetHighLightWidth(double lw)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SetHighLightWidth_16(base.GetCppThis(), lw);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTreeMapHover_SetInteractor_17(HandleRef pThis, HandleRef rwi);

		public override void SetInteractor(vtkRenderWindowInteractor rwi)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SetInteractor_17(base.GetCppThis(), (rwi == null) ? default(HandleRef) : rwi.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTreeMapHover_SetLabelField_18(HandleRef pThis, string _arg);

		public virtual void SetLabelField(string _arg)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SetLabelField_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTreeMapHover_SetLayout_19(HandleRef pThis, HandleRef layout);

		public void SetLayout(vtkTreeMapLayout layout)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SetLayout_19(base.GetCppThis(), (layout == null) ? default(HandleRef) : layout.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTreeMapHover_SetSelectionLightColor_20(HandleRef pThis, double r, double g, double b);

		public void SetSelectionLightColor(double r, double g, double b)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SetSelectionLightColor_20(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTreeMapHover_SetSelectionWidth_21(HandleRef pThis, double lw);

		public void SetSelectionWidth(double lw)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SetSelectionWidth_21(base.GetCppThis(), lw);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTreeMapHover_SetTreeMapToPolyData_22(HandleRef pThis, HandleRef filter);

		public void SetTreeMapToPolyData(vtkTreeMapToPolyData filter)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SetTreeMapToPolyData_22(base.GetCppThis(), (filter == null) ? default(HandleRef) : filter.GetCppThis());
		}
	}
}
