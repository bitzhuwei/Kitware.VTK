using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageWeightedSum : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageWeightedSum";

		public new static readonly string MRClassNameKey;

		static vtkImageWeightedSum()
		{
			vtkImageWeightedSum.MRClassNameKey = "class vtkImageWeightedSum";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageWeightedSum.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageWeightedSum"));
		}

		public vtkImageWeightedSum(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageWeightedSum_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageWeightedSum New()
		{
			vtkImageWeightedSum result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageWeightedSum.vtkImageWeightedSum_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageWeightedSum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageWeightedSum() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageWeightedSum.vtkImageWeightedSum_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageWeightedSum_CalculateTotalWeight_01(HandleRef pThis);

		public double CalculateTotalWeight()
		{
			return vtkImageWeightedSum.vtkImageWeightedSum_CalculateTotalWeight_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageWeightedSum_GetNormalizeByWeight_02(HandleRef pThis);

		public virtual int GetNormalizeByWeight()
		{
			return vtkImageWeightedSum.vtkImageWeightedSum_GetNormalizeByWeight_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageWeightedSum_GetNormalizeByWeightMaxValue_03(HandleRef pThis);

		public virtual int GetNormalizeByWeightMaxValue()
		{
			return vtkImageWeightedSum.vtkImageWeightedSum_GetNormalizeByWeightMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageWeightedSum_GetNormalizeByWeightMinValue_04(HandleRef pThis);

		public virtual int GetNormalizeByWeightMinValue()
		{
			return vtkImageWeightedSum.vtkImageWeightedSum_GetNormalizeByWeightMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageWeightedSum_GetWeights_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDoubleArray GetWeights()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageWeightedSum.vtkImageWeightedSum_GetWeights_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageWeightedSum_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageWeightedSum.vtkImageWeightedSum_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageWeightedSum_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageWeightedSum.vtkImageWeightedSum_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageWeightedSum_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageWeightedSum NewInstance()
		{
			vtkImageWeightedSum result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageWeightedSum.vtkImageWeightedSum_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageWeightedSum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageWeightedSum_NormalizeByWeightOff_10(HandleRef pThis);

		public virtual void NormalizeByWeightOff()
		{
			vtkImageWeightedSum.vtkImageWeightedSum_NormalizeByWeightOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageWeightedSum_NormalizeByWeightOn_11(HandleRef pThis);

		public virtual void NormalizeByWeightOn()
		{
			vtkImageWeightedSum.vtkImageWeightedSum_NormalizeByWeightOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageWeightedSum_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageWeightedSum SafeDownCast(vtkObjectBase o)
		{
			vtkImageWeightedSum vtkImageWeightedSum = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageWeightedSum.vtkImageWeightedSum_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageWeightedSum = (vtkImageWeightedSum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageWeightedSum.Register(null);
				}
			}
			return vtkImageWeightedSum;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageWeightedSum_SetNormalizeByWeight_13(HandleRef pThis, int _arg);

		public virtual void SetNormalizeByWeight(int _arg)
		{
			vtkImageWeightedSum.vtkImageWeightedSum_SetNormalizeByWeight_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageWeightedSum_SetWeight_14(HandleRef pThis, long id, double weight);

		public virtual void SetWeight(long id, double weight)
		{
			vtkImageWeightedSum.vtkImageWeightedSum_SetWeight_14(base.GetCppThis(), id, weight);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageWeightedSum_SetWeights_15(HandleRef pThis, HandleRef arg0);

		public virtual void SetWeights(vtkDoubleArray arg0)
		{
			vtkImageWeightedSum.vtkImageWeightedSum_SetWeights_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
