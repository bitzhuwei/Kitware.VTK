using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPiecewiseFunctionItem : vtkScalarsToColorsItem
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPiecewiseFunctionItem";

		public new static readonly string MRClassNameKey;

		static vtkPiecewiseFunctionItem()
		{
			vtkPiecewiseFunctionItem.MRClassNameKey = "class vtkPiecewiseFunctionItem";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPiecewiseFunctionItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPiecewiseFunctionItem"));
		}

		public vtkPiecewiseFunctionItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseFunctionItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPiecewiseFunctionItem New()
		{
			vtkPiecewiseFunctionItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseFunctionItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPiecewiseFunctionItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunctionItem_GetBounds_01(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_GetBounds_01(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseFunctionItem_GetPiecewiseFunction_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPiecewiseFunction GetPiecewiseFunction()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_GetPiecewiseFunction_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPiecewiseFunctionItem_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPiecewiseFunctionItem_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseFunctionItem_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPiecewiseFunctionItem NewInstance()
		{
			vtkPiecewiseFunctionItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseFunctionItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseFunctionItem_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPiecewiseFunctionItem SafeDownCast(vtkObjectBase o)
		{
			vtkPiecewiseFunctionItem vtkPiecewiseFunctionItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunctionItem = (vtkPiecewiseFunctionItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunctionItem.Register(null);
				}
			}
			return vtkPiecewiseFunctionItem;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunctionItem_SetPiecewiseFunction_08(HandleRef pThis, HandleRef t);

		public void SetPiecewiseFunction(vtkPiecewiseFunction t)
		{
			vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_SetPiecewiseFunction_08(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}
	}
}
