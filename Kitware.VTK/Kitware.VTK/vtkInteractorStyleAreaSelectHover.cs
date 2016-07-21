using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleAreaSelectHover : vtkInteractorStyleRubberBand2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleAreaSelectHover";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleAreaSelectHover()
		{
			vtkInteractorStyleAreaSelectHover.MRClassNameKey = "class vtkInteractorStyleAreaSelectHover";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleAreaSelectHover.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleAreaSelectHover"));
		}

		public vtkInteractorStyleAreaSelectHover(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleAreaSelectHover_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleAreaSelectHover New()
		{
			vtkInteractorStyleAreaSelectHover result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleAreaSelectHover)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleAreaSelectHover() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkInteractorStyleAreaSelectHover_GetHighLightWidth_01(HandleRef pThis);

		public double GetHighLightWidth()
		{
			return vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_GetHighLightWidth_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern long vtkInteractorStyleAreaSelectHover_GetIdAtPos_02(HandleRef pThis, int x, int y);

		public long GetIdAtPos(int x, int y)
		{
			return vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_GetIdAtPos_02(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleAreaSelectHover_GetLabelField_03(HandleRef pThis);

		public virtual string GetLabelField()
		{
			return Marshal.PtrToStringAnsi(vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_GetLabelField_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleAreaSelectHover_GetLayout_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAreaLayout GetLayout()
		{
			vtkAreaLayout vtkAreaLayout = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_GetLayout_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAreaLayout = (vtkAreaLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAreaLayout.Register(null);
				}
			}
			return vtkAreaLayout;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkInteractorStyleAreaSelectHover_GetUseRectangularCoordinates_05(HandleRef pThis);

		public virtual bool GetUseRectangularCoordinates()
		{
			return vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_GetUseRectangularCoordinates_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleAreaSelectHover_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleAreaSelectHover_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleAreaSelectHover_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleAreaSelectHover NewInstance()
		{
			vtkInteractorStyleAreaSelectHover result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleAreaSelectHover)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleAreaSelectHover_OnMouseMove_10(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_OnMouseMove_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleAreaSelectHover_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleAreaSelectHover SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleAreaSelectHover vtkInteractorStyleAreaSelectHover = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleAreaSelectHover = (vtkInteractorStyleAreaSelectHover)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleAreaSelectHover.Register(null);
				}
			}
			return vtkInteractorStyleAreaSelectHover;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleAreaSelectHover_SetHighLightColor_12(HandleRef pThis, double r, double g, double b);

		public void SetHighLightColor(double r, double g, double b)
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_SetHighLightColor_12(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleAreaSelectHover_SetHighLightWidth_13(HandleRef pThis, double lw);

		public void SetHighLightWidth(double lw)
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_SetHighLightWidth_13(base.GetCppThis(), lw);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleAreaSelectHover_SetInteractor_14(HandleRef pThis, HandleRef rwi);

		public override void SetInteractor(vtkRenderWindowInteractor rwi)
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_SetInteractor_14(base.GetCppThis(), (rwi == null) ? default(HandleRef) : rwi.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleAreaSelectHover_SetLabelField_15(HandleRef pThis, string _arg);

		public virtual void SetLabelField(string _arg)
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_SetLabelField_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleAreaSelectHover_SetLayout_16(HandleRef pThis, HandleRef layout);

		public void SetLayout(vtkAreaLayout layout)
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_SetLayout_16(base.GetCppThis(), (layout == null) ? default(HandleRef) : layout.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleAreaSelectHover_SetUseRectangularCoordinates_17(HandleRef pThis, byte _arg);

		public virtual void SetUseRectangularCoordinates(bool _arg)
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_SetUseRectangularCoordinates_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleAreaSelectHover_UseRectangularCoordinatesOff_18(HandleRef pThis);

		public virtual void UseRectangularCoordinatesOff()
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_UseRectangularCoordinatesOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleAreaSelectHover_UseRectangularCoordinatesOn_19(HandleRef pThis);

		public virtual void UseRectangularCoordinatesOn()
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_UseRectangularCoordinatesOn_19(base.GetCppThis());
		}
	}
}
