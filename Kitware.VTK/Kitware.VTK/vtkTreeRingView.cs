using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTreeRingView : vtkTreeAreaView
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeRingView";

		public new static readonly string MRClassNameKey;

		static vtkTreeRingView()
		{
			vtkTreeRingView.MRClassNameKey = "class vtkTreeRingView";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeRingView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeRingView"));
		}

		public vtkTreeRingView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeRingView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeRingView New()
		{
			vtkTreeRingView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeRingView.vtkTreeRingView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeRingView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTreeRingView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTreeRingView.vtkTreeRingView_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkTreeRingView_GetInteriorLogSpacingValue_01(HandleRef pThis);

		public virtual double GetInteriorLogSpacingValue()
		{
			return vtkTreeRingView.vtkTreeRingView_GetInteriorLogSpacingValue_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkTreeRingView_GetInteriorRadius_02(HandleRef pThis);

		public virtual double GetInteriorRadius()
		{
			return vtkTreeRingView.vtkTreeRingView_GetInteriorRadius_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkTreeRingView_GetLayerThickness_03(HandleRef pThis);

		public virtual double GetLayerThickness()
		{
			return vtkTreeRingView.vtkTreeRingView_GetLayerThickness_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkTreeRingView_GetRootAtCenter_04(HandleRef pThis);

		public virtual bool GetRootAtCenter()
		{
			return vtkTreeRingView.vtkTreeRingView_GetRootAtCenter_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkTreeRingView_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTreeRingView.vtkTreeRingView_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkTreeRingView_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTreeRingView.vtkTreeRingView_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeRingView_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTreeRingView NewInstance()
		{
			vtkTreeRingView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeRingView.vtkTreeRingView_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeRingView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeRingView_RootAtCenterOff_09(HandleRef pThis);

		public virtual void RootAtCenterOff()
		{
			vtkTreeRingView.vtkTreeRingView_RootAtCenterOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeRingView_RootAtCenterOn_10(HandleRef pThis);

		public virtual void RootAtCenterOn()
		{
			vtkTreeRingView.vtkTreeRingView_RootAtCenterOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeRingView_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeRingView SafeDownCast(vtkObjectBase o)
		{
			vtkTreeRingView vtkTreeRingView = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeRingView.vtkTreeRingView_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeRingView = (vtkTreeRingView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeRingView.Register(null);
				}
			}
			return vtkTreeRingView;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeRingView_SetInteriorLogSpacingValue_12(HandleRef pThis, double thickness);

		public virtual void SetInteriorLogSpacingValue(double thickness)
		{
			vtkTreeRingView.vtkTreeRingView_SetInteriorLogSpacingValue_12(base.GetCppThis(), thickness);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeRingView_SetInteriorRadius_13(HandleRef pThis, double thickness);

		public virtual void SetInteriorRadius(double thickness)
		{
			vtkTreeRingView.vtkTreeRingView_SetInteriorRadius_13(base.GetCppThis(), thickness);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeRingView_SetLayerThickness_14(HandleRef pThis, double thickness);

		public virtual void SetLayerThickness(double thickness)
		{
			vtkTreeRingView.vtkTreeRingView_SetLayerThickness_14(base.GetCppThis(), thickness);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeRingView_SetRootAngles_15(HandleRef pThis, double start, double end);

		public void SetRootAngles(double start, double end)
		{
			vtkTreeRingView.vtkTreeRingView_SetRootAngles_15(base.GetCppThis(), start, end);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeRingView_SetRootAtCenter_16(HandleRef pThis, byte value);

		public virtual void SetRootAtCenter(bool value)
		{
			vtkTreeRingView.vtkTreeRingView_SetRootAtCenter_16(base.GetCppThis(), value ? (byte)1 : (byte)0);
		}
	}
}
