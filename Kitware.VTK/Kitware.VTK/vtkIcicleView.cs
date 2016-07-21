using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkIcicleView : vtkTreeAreaView
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkIcicleView";

		public new static readonly string MRClassNameKey;

		static vtkIcicleView()
		{
			vtkIcicleView.MRClassNameKey = "class vtkIcicleView";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIcicleView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIcicleView"));
		}

		public vtkIcicleView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkIcicleView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIcicleView New()
		{
			vtkIcicleView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIcicleView.vtkIcicleView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIcicleView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkIcicleView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkIcicleView.vtkIcicleView_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkIcicleView_GetLayerThickness_01(HandleRef pThis);

		public virtual double GetLayerThickness()
		{
			return vtkIcicleView.vtkIcicleView_GetLayerThickness_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkIcicleView_GetRootWidth_02(HandleRef pThis);

		public virtual double GetRootWidth()
		{
			return vtkIcicleView.vtkIcicleView_GetRootWidth_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkIcicleView_GetTopToBottom_03(HandleRef pThis);

		public virtual bool GetTopToBottom()
		{
			return vtkIcicleView.vtkIcicleView_GetTopToBottom_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkIcicleView_GetUseGradientColoring_04(HandleRef pThis);

		public virtual bool GetUseGradientColoring()
		{
			return vtkIcicleView.vtkIcicleView_GetUseGradientColoring_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkIcicleView_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkIcicleView.vtkIcicleView_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkIcicleView_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkIcicleView.vtkIcicleView_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkIcicleView_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkIcicleView NewInstance()
		{
			vtkIcicleView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIcicleView.vtkIcicleView_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIcicleView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkIcicleView_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIcicleView SafeDownCast(vtkObjectBase o)
		{
			vtkIcicleView vtkIcicleView = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIcicleView.vtkIcicleView_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIcicleView = (vtkIcicleView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIcicleView.Register(null);
				}
			}
			return vtkIcicleView;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkIcicleView_SetLayerThickness_10(HandleRef pThis, double thickness);

		public virtual void SetLayerThickness(double thickness)
		{
			vtkIcicleView.vtkIcicleView_SetLayerThickness_10(base.GetCppThis(), thickness);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkIcicleView_SetRootWidth_11(HandleRef pThis, double width);

		public virtual void SetRootWidth(double width)
		{
			vtkIcicleView.vtkIcicleView_SetRootWidth_11(base.GetCppThis(), width);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkIcicleView_SetTopToBottom_12(HandleRef pThis, byte value);

		public virtual void SetTopToBottom(bool value)
		{
			vtkIcicleView.vtkIcicleView_SetTopToBottom_12(base.GetCppThis(), value ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkIcicleView_SetUseGradientColoring_13(HandleRef pThis, byte value);

		public virtual void SetUseGradientColoring(bool value)
		{
			vtkIcicleView.vtkIcicleView_SetUseGradientColoring_13(base.GetCppThis(), value ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkIcicleView_TopToBottomOff_14(HandleRef pThis);

		public virtual void TopToBottomOff()
		{
			vtkIcicleView.vtkIcicleView_TopToBottomOff_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkIcicleView_TopToBottomOn_15(HandleRef pThis);

		public virtual void TopToBottomOn()
		{
			vtkIcicleView.vtkIcicleView_TopToBottomOn_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkIcicleView_UseGradientColoringOff_16(HandleRef pThis);

		public virtual void UseGradientColoringOff()
		{
			vtkIcicleView.vtkIcicleView_UseGradientColoringOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkIcicleView_UseGradientColoringOn_17(HandleRef pThis);

		public virtual void UseGradientColoringOn()
		{
			vtkIcicleView.vtkIcicleView_UseGradientColoringOn_17(base.GetCppThis());
		}
	}
}
