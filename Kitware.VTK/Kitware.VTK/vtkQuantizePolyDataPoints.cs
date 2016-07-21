using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkQuantizePolyDataPoints : vtkCleanPolyData
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuantizePolyDataPoints";

		public new static readonly string MRClassNameKey;

		static vtkQuantizePolyDataPoints()
		{
			vtkQuantizePolyDataPoints.MRClassNameKey = "class vtkQuantizePolyDataPoints";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuantizePolyDataPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuantizePolyDataPoints"));
		}

		public vtkQuantizePolyDataPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuantizePolyDataPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuantizePolyDataPoints New()
		{
			vtkQuantizePolyDataPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuantizePolyDataPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkQuantizePolyDataPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkQuantizePolyDataPoints_GetQFactor_01(HandleRef pThis);

		public virtual double GetQFactor()
		{
			return vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_GetQFactor_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkQuantizePolyDataPoints_GetQFactorMaxValue_02(HandleRef pThis);

		public virtual double GetQFactorMaxValue()
		{
			return vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_GetQFactorMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkQuantizePolyDataPoints_GetQFactorMinValue_03(HandleRef pThis);

		public virtual double GetQFactorMinValue()
		{
			return vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_GetQFactorMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuantizePolyDataPoints_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuantizePolyDataPoints_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuantizePolyDataPoints_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkQuantizePolyDataPoints NewInstance()
		{
			vtkQuantizePolyDataPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuantizePolyDataPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuantizePolyDataPoints_OperateOnBounds_08(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public override void OperateOnBounds(IntPtr arg0, IntPtr arg1)
		{
			vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_OperateOnBounds_08(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuantizePolyDataPoints_OperateOnPoint_09(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public override void OperateOnPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_OperateOnPoint_09(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuantizePolyDataPoints_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuantizePolyDataPoints SafeDownCast(vtkObjectBase o)
		{
			vtkQuantizePolyDataPoints vtkQuantizePolyDataPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuantizePolyDataPoints = (vtkQuantizePolyDataPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuantizePolyDataPoints.Register(null);
				}
			}
			return vtkQuantizePolyDataPoints;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuantizePolyDataPoints_SetQFactor_11(HandleRef pThis, double _arg);

		public virtual void SetQFactor(double _arg)
		{
			vtkQuantizePolyDataPoints.vtkQuantizePolyDataPoints_SetQFactor_11(base.GetCppThis(), _arg);
		}
	}
}
