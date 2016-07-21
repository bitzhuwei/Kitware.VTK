using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBrownianPoints : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBrownianPoints";

		public new static readonly string MRClassNameKey;

		static vtkBrownianPoints()
		{
			vtkBrownianPoints.MRClassNameKey = "class vtkBrownianPoints";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBrownianPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBrownianPoints"));
		}

		public vtkBrownianPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBrownianPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBrownianPoints New()
		{
			vtkBrownianPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBrownianPoints.vtkBrownianPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBrownianPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBrownianPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBrownianPoints.vtkBrownianPoints_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkBrownianPoints_GetMaximumSpeed_01(HandleRef pThis);

		public virtual double GetMaximumSpeed()
		{
			return vtkBrownianPoints.vtkBrownianPoints_GetMaximumSpeed_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkBrownianPoints_GetMaximumSpeedMaxValue_02(HandleRef pThis);

		public virtual double GetMaximumSpeedMaxValue()
		{
			return vtkBrownianPoints.vtkBrownianPoints_GetMaximumSpeedMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkBrownianPoints_GetMaximumSpeedMinValue_03(HandleRef pThis);

		public virtual double GetMaximumSpeedMinValue()
		{
			return vtkBrownianPoints.vtkBrownianPoints_GetMaximumSpeedMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkBrownianPoints_GetMinimumSpeed_04(HandleRef pThis);

		public virtual double GetMinimumSpeed()
		{
			return vtkBrownianPoints.vtkBrownianPoints_GetMinimumSpeed_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkBrownianPoints_GetMinimumSpeedMaxValue_05(HandleRef pThis);

		public virtual double GetMinimumSpeedMaxValue()
		{
			return vtkBrownianPoints.vtkBrownianPoints_GetMinimumSpeedMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkBrownianPoints_GetMinimumSpeedMinValue_06(HandleRef pThis);

		public virtual double GetMinimumSpeedMinValue()
		{
			return vtkBrownianPoints.vtkBrownianPoints_GetMinimumSpeedMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBrownianPoints_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBrownianPoints.vtkBrownianPoints_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBrownianPoints_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBrownianPoints.vtkBrownianPoints_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBrownianPoints_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBrownianPoints NewInstance()
		{
			vtkBrownianPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBrownianPoints.vtkBrownianPoints_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBrownianPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBrownianPoints_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBrownianPoints SafeDownCast(vtkObjectBase o)
		{
			vtkBrownianPoints vtkBrownianPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBrownianPoints.vtkBrownianPoints_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBrownianPoints = (vtkBrownianPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBrownianPoints.Register(null);
				}
			}
			return vtkBrownianPoints;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBrownianPoints_SetMaximumSpeed_12(HandleRef pThis, double _arg);

		public virtual void SetMaximumSpeed(double _arg)
		{
			vtkBrownianPoints.vtkBrownianPoints_SetMaximumSpeed_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBrownianPoints_SetMinimumSpeed_13(HandleRef pThis, double _arg);

		public virtual void SetMinimumSpeed(double _arg)
		{
			vtkBrownianPoints.vtkBrownianPoints_SetMinimumSpeed_13(base.GetCppThis(), _arg);
		}
	}
}
