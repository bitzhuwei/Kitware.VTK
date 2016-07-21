using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPiecewiseControlPointsItem : vtkControlPointsItem
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPiecewiseControlPointsItem";

		public new static readonly string MRClassNameKey;

		static vtkPiecewiseControlPointsItem()
		{
			vtkPiecewiseControlPointsItem.MRClassNameKey = "class vtkPiecewiseControlPointsItem";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPiecewiseControlPointsItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPiecewiseControlPointsItem"));
		}

		public vtkPiecewiseControlPointsItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseControlPointsItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPiecewiseControlPointsItem New()
		{
			vtkPiecewiseControlPointsItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPiecewiseControlPointsItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern long vtkPiecewiseControlPointsItem_AddPoint_01(HandleRef pThis, IntPtr newPos);

		public override long AddPoint(IntPtr newPos)
		{
			return vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_AddPoint_01(base.GetCppThis(), newPos);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseControlPointsItem_GetPiecewiseFunction_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPiecewiseFunction GetPiecewiseFunction()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_GetPiecewiseFunction_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPiecewiseControlPointsItem_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPiecewiseControlPointsItem_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseControlPointsItem_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPiecewiseControlPointsItem NewInstance()
		{
			vtkPiecewiseControlPointsItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern long vtkPiecewiseControlPointsItem_RemovePoint_07(HandleRef pThis, IntPtr pos);

		public override long RemovePoint(IntPtr pos)
		{
			return vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_RemovePoint_07(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseControlPointsItem_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPiecewiseControlPointsItem SafeDownCast(vtkObjectBase o)
		{
			vtkPiecewiseControlPointsItem vtkPiecewiseControlPointsItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseControlPointsItem = (vtkPiecewiseControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseControlPointsItem.Register(null);
				}
			}
			return vtkPiecewiseControlPointsItem;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPiecewiseControlPointsItem_SetPiecewiseFunction_09(HandleRef pThis, HandleRef function);

		public virtual void SetPiecewiseFunction(vtkPiecewiseFunction function)
		{
			vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_SetPiecewiseFunction_09(base.GetCppThis(), (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPiecewiseControlPointsItem_SetStrokeMode_10(HandleRef pThis, byte _arg);

		public virtual void SetStrokeMode(bool _arg)
		{
			vtkPiecewiseControlPointsItem.vtkPiecewiseControlPointsItem_SetStrokeMode_10(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
