using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStreamPoints : vtkStreamer
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStreamPoints";

		public new static readonly string MRClassNameKey;

		static vtkStreamPoints()
		{
			vtkStreamPoints.MRClassNameKey = "class vtkStreamPoints";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStreamPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamPoints"));
		}

		public vtkStreamPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStreamPoints New()
		{
			vtkStreamPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamPoints.vtkStreamPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStreamPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStreamPoints.vtkStreamPoints_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamPoints_GetTimeIncrement_01(HandleRef pThis);

		public virtual double GetTimeIncrement()
		{
			return vtkStreamPoints.vtkStreamPoints_GetTimeIncrement_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamPoints_GetTimeIncrementMaxValue_02(HandleRef pThis);

		public virtual double GetTimeIncrementMaxValue()
		{
			return vtkStreamPoints.vtkStreamPoints_GetTimeIncrementMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamPoints_GetTimeIncrementMinValue_03(HandleRef pThis);

		public virtual double GetTimeIncrementMinValue()
		{
			return vtkStreamPoints.vtkStreamPoints_GetTimeIncrementMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamPoints_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStreamPoints.vtkStreamPoints_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamPoints_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStreamPoints.vtkStreamPoints_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamPoints_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStreamPoints NewInstance()
		{
			vtkStreamPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamPoints.vtkStreamPoints_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamPoints_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStreamPoints SafeDownCast(vtkObjectBase o)
		{
			vtkStreamPoints vtkStreamPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamPoints.vtkStreamPoints_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStreamPoints = (vtkStreamPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStreamPoints.Register(null);
				}
			}
			return vtkStreamPoints;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamPoints_SetTimeIncrement_09(HandleRef pThis, double _arg);

		public virtual void SetTimeIncrement(double _arg)
		{
			vtkStreamPoints.vtkStreamPoints_SetTimeIncrement_09(base.GetCppThis(), _arg);
		}
	}
}
