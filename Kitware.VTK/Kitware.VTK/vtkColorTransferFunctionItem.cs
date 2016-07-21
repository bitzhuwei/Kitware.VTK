using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkColorTransferFunctionItem : vtkScalarsToColorsItem
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkColorTransferFunctionItem";

		public new static readonly string MRClassNameKey;

		static vtkColorTransferFunctionItem()
		{
			vtkColorTransferFunctionItem.MRClassNameKey = "class vtkColorTransferFunctionItem";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkColorTransferFunctionItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkColorTransferFunctionItem"));
		}

		public vtkColorTransferFunctionItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferFunctionItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkColorTransferFunctionItem New()
		{
			vtkColorTransferFunctionItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorTransferFunctionItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkColorTransferFunctionItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunctionItem_GetBounds_01(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_GetBounds_01(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferFunctionItem_GetColorTransferFunction_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkColorTransferFunction GetColorTransferFunction()
		{
			vtkColorTransferFunction vtkColorTransferFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_GetColorTransferFunction_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorTransferFunction = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorTransferFunction.Register(null);
				}
			}
			return vtkColorTransferFunction;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunctionItem_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunctionItem_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferFunctionItem_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkColorTransferFunctionItem NewInstance()
		{
			vtkColorTransferFunctionItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorTransferFunctionItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferFunctionItem_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkColorTransferFunctionItem SafeDownCast(vtkObjectBase o)
		{
			vtkColorTransferFunctionItem vtkColorTransferFunctionItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorTransferFunctionItem = (vtkColorTransferFunctionItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorTransferFunctionItem.Register(null);
				}
			}
			return vtkColorTransferFunctionItem;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunctionItem_SetColorTransferFunction_08(HandleRef pThis, HandleRef t);

		public void SetColorTransferFunction(vtkColorTransferFunction t)
		{
			vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_SetColorTransferFunction_08(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}
	}
}
