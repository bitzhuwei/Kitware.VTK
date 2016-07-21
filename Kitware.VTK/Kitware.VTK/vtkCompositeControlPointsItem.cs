using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCompositeControlPointsItem : vtkColorTransferControlPointsItem
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeControlPointsItem";

		public new static readonly string MRClassNameKey;

		static vtkCompositeControlPointsItem()
		{
			vtkCompositeControlPointsItem.MRClassNameKey = "class vtkCompositeControlPointsItem";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeControlPointsItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeControlPointsItem"));
		}

		public vtkCompositeControlPointsItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeControlPointsItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositeControlPointsItem New()
		{
			vtkCompositeControlPointsItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCompositeControlPointsItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern long vtkCompositeControlPointsItem_AddPoint_01(HandleRef pThis, IntPtr newPos);

		public override long AddPoint(IntPtr newPos)
		{
			return vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_AddPoint_01(base.GetCppThis(), newPos);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeControlPointsItem_GetOpacityFunction_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPiecewiseFunction GetOpacityFunction()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_GetOpacityFunction_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkCompositeControlPointsItem_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkCompositeControlPointsItem_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeControlPointsItem_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCompositeControlPointsItem NewInstance()
		{
			vtkCompositeControlPointsItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern long vtkCompositeControlPointsItem_RemovePoint_07(HandleRef pThis, IntPtr pos);

		public override long RemovePoint(IntPtr pos)
		{
			return vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_RemovePoint_07(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeControlPointsItem_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositeControlPointsItem SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeControlPointsItem vtkCompositeControlPointsItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeControlPointsItem = (vtkCompositeControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeControlPointsItem.Register(null);
				}
			}
			return vtkCompositeControlPointsItem;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkCompositeControlPointsItem_SetColorTransferFunction_09(HandleRef pThis, HandleRef function);

		public new virtual void SetColorTransferFunction(vtkColorTransferFunction function)
		{
			vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_SetColorTransferFunction_09(base.GetCppThis(), (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkCompositeControlPointsItem_SetOpacityFunction_10(HandleRef pThis, HandleRef opacity);

		public void SetOpacityFunction(vtkPiecewiseFunction opacity)
		{
			vtkCompositeControlPointsItem.vtkCompositeControlPointsItem_SetOpacityFunction_10(base.GetCppThis(), (opacity == null) ? default(HandleRef) : opacity.GetCppThis());
		}
	}
}
