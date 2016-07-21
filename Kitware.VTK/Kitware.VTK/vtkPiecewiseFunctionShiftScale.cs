using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPiecewiseFunctionShiftScale : vtkPiecewiseFunctionAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPiecewiseFunctionShiftScale";

		public new static readonly string MRClassNameKey;

		static vtkPiecewiseFunctionShiftScale()
		{
			vtkPiecewiseFunctionShiftScale.MRClassNameKey = "class vtkPiecewiseFunctionShiftScale";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPiecewiseFunctionShiftScale.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPiecewiseFunctionShiftScale"));
		}

		public vtkPiecewiseFunctionShiftScale(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseFunctionShiftScale_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPiecewiseFunctionShiftScale New()
		{
			vtkPiecewiseFunctionShiftScale result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseFunctionShiftScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPiecewiseFunctionShiftScale() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkPiecewiseFunctionShiftScale_GetPositionScale_01(HandleRef pThis);

		public virtual double GetPositionScale()
		{
			return vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_GetPositionScale_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkPiecewiseFunctionShiftScale_GetPositionShift_02(HandleRef pThis);

		public virtual double GetPositionShift()
		{
			return vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_GetPositionShift_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkPiecewiseFunctionShiftScale_GetValueScale_03(HandleRef pThis);

		public virtual double GetValueScale()
		{
			return vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_GetValueScale_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkPiecewiseFunctionShiftScale_GetValueShift_04(HandleRef pThis);

		public virtual double GetValueShift()
		{
			return vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_GetValueShift_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPiecewiseFunctionShiftScale_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPiecewiseFunctionShiftScale_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseFunctionShiftScale_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPiecewiseFunctionShiftScale NewInstance()
		{
			vtkPiecewiseFunctionShiftScale result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseFunctionShiftScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseFunctionShiftScale_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPiecewiseFunctionShiftScale SafeDownCast(vtkObjectBase o)
		{
			vtkPiecewiseFunctionShiftScale vtkPiecewiseFunctionShiftScale = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunctionShiftScale = (vtkPiecewiseFunctionShiftScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunctionShiftScale.Register(null);
				}
			}
			return vtkPiecewiseFunctionShiftScale;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunctionShiftScale_SetPositionScale_10(HandleRef pThis, double _arg);

		public virtual void SetPositionScale(double _arg)
		{
			vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_SetPositionScale_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunctionShiftScale_SetPositionShift_11(HandleRef pThis, double _arg);

		public virtual void SetPositionShift(double _arg)
		{
			vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_SetPositionShift_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunctionShiftScale_SetValueScale_12(HandleRef pThis, double _arg);

		public virtual void SetValueScale(double _arg)
		{
			vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_SetValueScale_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunctionShiftScale_SetValueShift_13(HandleRef pThis, double _arg);

		public virtual void SetValueShift(double _arg)
		{
			vtkPiecewiseFunctionShiftScale.vtkPiecewiseFunctionShiftScale_SetValueShift_13(base.GetCppThis(), _arg);
		}
	}
}
