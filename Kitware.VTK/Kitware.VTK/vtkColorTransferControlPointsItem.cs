using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkColorTransferControlPointsItem : vtkControlPointsItem
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkColorTransferControlPointsItem";

		public new static readonly string MRClassNameKey;

		static vtkColorTransferControlPointsItem()
		{
			vtkColorTransferControlPointsItem.MRClassNameKey = "class vtkColorTransferControlPointsItem";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkColorTransferControlPointsItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkColorTransferControlPointsItem"));
		}

		public vtkColorTransferControlPointsItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferControlPointsItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkColorTransferControlPointsItem New()
		{
			vtkColorTransferControlPointsItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorTransferControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkColorTransferControlPointsItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern long vtkColorTransferControlPointsItem_AddPoint_01(HandleRef pThis, IntPtr newPos);

		public override long AddPoint(IntPtr newPos)
		{
			return vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_AddPoint_01(base.GetCppThis(), newPos);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkColorTransferControlPointsItem_GetColorFill_02(HandleRef pThis);

		public virtual bool GetColorFill()
		{
			return vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_GetColorFill_02(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferControlPointsItem_GetColorTransferFunction_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkColorTransferFunction GetColorTransferFunction()
		{
			vtkColorTransferFunction vtkColorTransferFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_GetColorTransferFunction_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkColorTransferControlPointsItem_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkColorTransferControlPointsItem_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferControlPointsItem_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkColorTransferControlPointsItem NewInstance()
		{
			vtkColorTransferControlPointsItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorTransferControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern long vtkColorTransferControlPointsItem_RemovePoint_08(HandleRef pThis, IntPtr pos);

		public override long RemovePoint(IntPtr pos)
		{
			return vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_RemovePoint_08(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferControlPointsItem_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkColorTransferControlPointsItem SafeDownCast(vtkObjectBase o)
		{
			vtkColorTransferControlPointsItem vtkColorTransferControlPointsItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorTransferControlPointsItem = (vtkColorTransferControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorTransferControlPointsItem.Register(null);
				}
			}
			return vtkColorTransferControlPointsItem;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkColorTransferControlPointsItem_SetColorFill_10(HandleRef pThis, byte _arg);

		public virtual void SetColorFill(bool _arg)
		{
			vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_SetColorFill_10(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkColorTransferControlPointsItem_SetColorTransferFunction_11(HandleRef pThis, HandleRef function);

		public void SetColorTransferFunction(vtkColorTransferFunction function)
		{
			vtkColorTransferControlPointsItem.vtkColorTransferControlPointsItem_SetColorTransferFunction_11(base.GetCppThis(), (function == null) ? default(HandleRef) : function.GetCppThis());
		}
	}
}
