using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMinimalStandardRandomSequence : vtkRandomSequence
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMinimalStandardRandomSequence";

		public new static readonly string MRClassNameKey;

		static vtkMinimalStandardRandomSequence()
		{
			vtkMinimalStandardRandomSequence.MRClassNameKey = "class vtkMinimalStandardRandomSequence";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMinimalStandardRandomSequence.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMinimalStandardRandomSequence"));
		}

		public vtkMinimalStandardRandomSequence(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMinimalStandardRandomSequence_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMinimalStandardRandomSequence New()
		{
			vtkMinimalStandardRandomSequence result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMinimalStandardRandomSequence.vtkMinimalStandardRandomSequence_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMinimalStandardRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMinimalStandardRandomSequence() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMinimalStandardRandomSequence.vtkMinimalStandardRandomSequence_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMinimalStandardRandomSequence_GetRangeValue_01(HandleRef pThis, double rangeMin, double rangeMax);

		public virtual double GetRangeValue(double rangeMin, double rangeMax)
		{
			return vtkMinimalStandardRandomSequence.vtkMinimalStandardRandomSequence_GetRangeValue_01(base.GetCppThis(), rangeMin, rangeMax);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMinimalStandardRandomSequence_GetSeed_02(HandleRef pThis);

		public int GetSeed()
		{
			return vtkMinimalStandardRandomSequence.vtkMinimalStandardRandomSequence_GetSeed_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMinimalStandardRandomSequence_GetValue_03(HandleRef pThis);

		public override double GetValue()
		{
			return vtkMinimalStandardRandomSequence.vtkMinimalStandardRandomSequence_GetValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMinimalStandardRandomSequence_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMinimalStandardRandomSequence.vtkMinimalStandardRandomSequence_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMinimalStandardRandomSequence_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMinimalStandardRandomSequence.vtkMinimalStandardRandomSequence_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMinimalStandardRandomSequence_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMinimalStandardRandomSequence NewInstance()
		{
			vtkMinimalStandardRandomSequence result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMinimalStandardRandomSequence.vtkMinimalStandardRandomSequence_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMinimalStandardRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMinimalStandardRandomSequence_Next_08(HandleRef pThis);

		public override void Next()
		{
			vtkMinimalStandardRandomSequence.vtkMinimalStandardRandomSequence_Next_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMinimalStandardRandomSequence_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMinimalStandardRandomSequence SafeDownCast(vtkObjectBase o)
		{
			vtkMinimalStandardRandomSequence vtkMinimalStandardRandomSequence = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMinimalStandardRandomSequence.vtkMinimalStandardRandomSequence_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMinimalStandardRandomSequence = (vtkMinimalStandardRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMinimalStandardRandomSequence.Register(null);
				}
			}
			return vtkMinimalStandardRandomSequence;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMinimalStandardRandomSequence_SetSeed_10(HandleRef pThis, int value);

		public void SetSeed(int value)
		{
			vtkMinimalStandardRandomSequence.vtkMinimalStandardRandomSequence_SetSeed_10(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMinimalStandardRandomSequence_SetSeedOnly_11(HandleRef pThis, int value);

		public void SetSeedOnly(int value)
		{
			vtkMinimalStandardRandomSequence.vtkMinimalStandardRandomSequence_SetSeedOnly_11(base.GetCppThis(), value);
		}
	}
}
