using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRecursiveDividingCubes : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRecursiveDividingCubes";

		public new static readonly string MRClassNameKey;

		static vtkRecursiveDividingCubes()
		{
			vtkRecursiveDividingCubes.MRClassNameKey = "class vtkRecursiveDividingCubes";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRecursiveDividingCubes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRecursiveDividingCubes"));
		}

		public vtkRecursiveDividingCubes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRecursiveDividingCubes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRecursiveDividingCubes New()
		{
			vtkRecursiveDividingCubes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRecursiveDividingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRecursiveDividingCubes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRecursiveDividingCubes_GetDistance_01(HandleRef pThis);

		public virtual double GetDistance()
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_GetDistance_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRecursiveDividingCubes_GetDistanceMaxValue_02(HandleRef pThis);

		public virtual double GetDistanceMaxValue()
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_GetDistanceMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRecursiveDividingCubes_GetDistanceMinValue_03(HandleRef pThis);

		public virtual double GetDistanceMinValue()
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_GetDistanceMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRecursiveDividingCubes_GetIncrement_04(HandleRef pThis);

		public virtual int GetIncrement()
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_GetIncrement_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRecursiveDividingCubes_GetIncrementMaxValue_05(HandleRef pThis);

		public virtual int GetIncrementMaxValue()
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_GetIncrementMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRecursiveDividingCubes_GetIncrementMinValue_06(HandleRef pThis);

		public virtual int GetIncrementMinValue()
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_GetIncrementMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRecursiveDividingCubes_GetValue_07(HandleRef pThis);

		public virtual double GetValue()
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_GetValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRecursiveDividingCubes_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRecursiveDividingCubes_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRecursiveDividingCubes_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRecursiveDividingCubes NewInstance()
		{
			vtkRecursiveDividingCubes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRecursiveDividingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRecursiveDividingCubes_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRecursiveDividingCubes SafeDownCast(vtkObjectBase o)
		{
			vtkRecursiveDividingCubes vtkRecursiveDividingCubes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRecursiveDividingCubes = (vtkRecursiveDividingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRecursiveDividingCubes.Register(null);
				}
			}
			return vtkRecursiveDividingCubes;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRecursiveDividingCubes_SetDistance_13(HandleRef pThis, double _arg);

		public virtual void SetDistance(double _arg)
		{
			vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_SetDistance_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRecursiveDividingCubes_SetIncrement_14(HandleRef pThis, int _arg);

		public virtual void SetIncrement(int _arg)
		{
			vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_SetIncrement_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRecursiveDividingCubes_SetValue_15(HandleRef pThis, double _arg);

		public virtual void SetValue(double _arg)
		{
			vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_SetValue_15(base.GetCppThis(), _arg);
		}
	}
}
