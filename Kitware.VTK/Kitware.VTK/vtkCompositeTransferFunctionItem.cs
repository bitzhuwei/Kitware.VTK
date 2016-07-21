using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCompositeTransferFunctionItem : vtkColorTransferFunctionItem
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeTransferFunctionItem";

		public new static readonly string MRClassNameKey;

		static vtkCompositeTransferFunctionItem()
		{
			vtkCompositeTransferFunctionItem.MRClassNameKey = "class vtkCompositeTransferFunctionItem";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeTransferFunctionItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeTransferFunctionItem"));
		}

		public vtkCompositeTransferFunctionItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeTransferFunctionItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositeTransferFunctionItem New()
		{
			vtkCompositeTransferFunctionItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeTransferFunctionItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCompositeTransferFunctionItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkCompositeTransferFunctionItem_GetBounds_01(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_GetBounds_01(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeTransferFunctionItem_GetOpacityFunction_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPiecewiseFunction GetOpacityFunction()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_GetOpacityFunction_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkCompositeTransferFunctionItem_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkCompositeTransferFunctionItem_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeTransferFunctionItem_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCompositeTransferFunctionItem NewInstance()
		{
			vtkCompositeTransferFunctionItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeTransferFunctionItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeTransferFunctionItem_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositeTransferFunctionItem SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeTransferFunctionItem vtkCompositeTransferFunctionItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeTransferFunctionItem = (vtkCompositeTransferFunctionItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeTransferFunctionItem.Register(null);
				}
			}
			return vtkCompositeTransferFunctionItem;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkCompositeTransferFunctionItem_SetOpacityFunction_08(HandleRef pThis, HandleRef opacity);

		public void SetOpacityFunction(vtkPiecewiseFunction opacity)
		{
			vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_SetOpacityFunction_08(base.GetCppThis(), (opacity == null) ? default(HandleRef) : opacity.GetCppThis());
		}
	}
}
