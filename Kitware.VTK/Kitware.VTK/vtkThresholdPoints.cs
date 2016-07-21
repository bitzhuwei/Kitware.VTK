using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkThresholdPoints : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkThresholdPoints";

		public new static readonly string MRClassNameKey;

		static vtkThresholdPoints()
		{
			vtkThresholdPoints.MRClassNameKey = "class vtkThresholdPoints";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThresholdPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThresholdPoints"));
		}

		public vtkThresholdPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkThresholdPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThresholdPoints New()
		{
			vtkThresholdPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThresholdPoints.vtkThresholdPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThresholdPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkThresholdPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkThresholdPoints.vtkThresholdPoints_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkThresholdPoints_GetLowerThreshold_01(HandleRef pThis);

		public virtual double GetLowerThreshold()
		{
			return vtkThresholdPoints.vtkThresholdPoints_GetLowerThreshold_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkThresholdPoints_GetUpperThreshold_02(HandleRef pThis);

		public virtual double GetUpperThreshold()
		{
			return vtkThresholdPoints.vtkThresholdPoints_GetUpperThreshold_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThresholdPoints_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkThresholdPoints.vtkThresholdPoints_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThresholdPoints_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkThresholdPoints.vtkThresholdPoints_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkThresholdPoints_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkThresholdPoints NewInstance()
		{
			vtkThresholdPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThresholdPoints.vtkThresholdPoints_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThresholdPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkThresholdPoints_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThresholdPoints SafeDownCast(vtkObjectBase o)
		{
			vtkThresholdPoints vtkThresholdPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThresholdPoints.vtkThresholdPoints_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThresholdPoints = (vtkThresholdPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThresholdPoints.Register(null);
				}
			}
			return vtkThresholdPoints;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThresholdPoints_SetLowerThreshold_08(HandleRef pThis, double _arg);

		public virtual void SetLowerThreshold(double _arg)
		{
			vtkThresholdPoints.vtkThresholdPoints_SetLowerThreshold_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThresholdPoints_SetUpperThreshold_09(HandleRef pThis, double _arg);

		public virtual void SetUpperThreshold(double _arg)
		{
			vtkThresholdPoints.vtkThresholdPoints_SetUpperThreshold_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThresholdPoints_ThresholdBetween_10(HandleRef pThis, double lower, double upper);

		public void ThresholdBetween(double lower, double upper)
		{
			vtkThresholdPoints.vtkThresholdPoints_ThresholdBetween_10(base.GetCppThis(), lower, upper);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThresholdPoints_ThresholdByLower_11(HandleRef pThis, double lower);

		public void ThresholdByLower(double lower)
		{
			vtkThresholdPoints.vtkThresholdPoints_ThresholdByLower_11(base.GetCppThis(), lower);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThresholdPoints_ThresholdByUpper_12(HandleRef pThis, double upper);

		public void ThresholdByUpper(double upper)
		{
			vtkThresholdPoints.vtkThresholdPoints_ThresholdByUpper_12(base.GetCppThis(), upper);
		}
	}
}
