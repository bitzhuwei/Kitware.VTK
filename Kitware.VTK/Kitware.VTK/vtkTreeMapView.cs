using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTreeMapView : vtkTreeAreaView
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeMapView";

		public new static readonly string MRClassNameKey;

		static vtkTreeMapView()
		{
			vtkTreeMapView.MRClassNameKey = "class vtkTreeMapView";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeMapView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeMapView"));
		}

		public vtkTreeMapView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeMapView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeMapView New()
		{
			vtkTreeMapView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeMapView.vtkTreeMapView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeMapView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTreeMapView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTreeMapView.vtkTreeMapView_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeMapView_GetFontSizeRange_01(HandleRef pThis, IntPtr range);

		public virtual void GetFontSizeRange(IntPtr range)
		{
			vtkTreeMapView.vtkTreeMapView_GetFontSizeRange_01(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkTreeMapView_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTreeMapView.vtkTreeMapView_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkTreeMapView_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTreeMapView.vtkTreeMapView_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeMapView_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTreeMapView NewInstance()
		{
			vtkTreeMapView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeMapView.vtkTreeMapView_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeMapView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeMapView_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeMapView SafeDownCast(vtkObjectBase o)
		{
			vtkTreeMapView vtkTreeMapView = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeMapView.vtkTreeMapView_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeMapView = (vtkTreeMapView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeMapView.Register(null);
				}
			}
			return vtkTreeMapView;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeMapView_SetFontSizeRange_07(HandleRef pThis, int maxSize, int minSize, int delta);

		public virtual void SetFontSizeRange(int maxSize, int minSize, int delta)
		{
			vtkTreeMapView.vtkTreeMapView_SetFontSizeRange_07(base.GetCppThis(), maxSize, minSize, delta);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeMapView_SetLayoutStrategy_08(HandleRef pThis, HandleRef s);

		public override void SetLayoutStrategy(vtkAreaLayoutStrategy s)
		{
			vtkTreeMapView.vtkTreeMapView_SetLayoutStrategy_08(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeMapView_SetLayoutStrategy_09(HandleRef pThis, string name);

		public virtual void SetLayoutStrategy(string name)
		{
			vtkTreeMapView.vtkTreeMapView_SetLayoutStrategy_09(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeMapView_SetLayoutStrategyToBox_10(HandleRef pThis);

		public virtual void SetLayoutStrategyToBox()
		{
			vtkTreeMapView.vtkTreeMapView_SetLayoutStrategyToBox_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeMapView_SetLayoutStrategyToSliceAndDice_11(HandleRef pThis);

		public virtual void SetLayoutStrategyToSliceAndDice()
		{
			vtkTreeMapView.vtkTreeMapView_SetLayoutStrategyToSliceAndDice_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkTreeMapView_SetLayoutStrategyToSquarify_12(HandleRef pThis);

		public virtual void SetLayoutStrategyToSquarify()
		{
			vtkTreeMapView.vtkTreeMapView_SetLayoutStrategyToSquarify_12(base.GetCppThis());
		}
	}
}
