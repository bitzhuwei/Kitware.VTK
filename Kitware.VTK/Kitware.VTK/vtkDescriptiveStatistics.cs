using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDescriptiveStatistics : vtkUnivariateStatisticsAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDescriptiveStatistics";

		public new static readonly string MRClassNameKey;

		static vtkDescriptiveStatistics()
		{
			vtkDescriptiveStatistics.MRClassNameKey = "class vtkDescriptiveStatistics";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDescriptiveStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDescriptiveStatistics"));
		}

		public vtkDescriptiveStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDescriptiveStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDescriptiveStatistics New()
		{
			vtkDescriptiveStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDescriptiveStatistics.vtkDescriptiveStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDescriptiveStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDescriptiveStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDescriptiveStatistics.vtkDescriptiveStatistics_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDescriptiveStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDescriptiveStatistics_G1SkewnessOff_02(HandleRef pThis);

		public virtual void G1SkewnessOff()
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_G1SkewnessOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDescriptiveStatistics_G1SkewnessOn_03(HandleRef pThis);

		public virtual void G1SkewnessOn()
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_G1SkewnessOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDescriptiveStatistics_G2KurtosisOff_04(HandleRef pThis);

		public virtual void G2KurtosisOff()
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_G2KurtosisOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDescriptiveStatistics_G2KurtosisOn_05(HandleRef pThis);

		public virtual void G2KurtosisOn()
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_G2KurtosisOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDescriptiveStatistics_GetG1Skewness_06(HandleRef pThis);

		public virtual int GetG1Skewness()
		{
			return vtkDescriptiveStatistics.vtkDescriptiveStatistics_GetG1Skewness_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDescriptiveStatistics_GetG2Kurtosis_07(HandleRef pThis);

		public virtual int GetG2Kurtosis()
		{
			return vtkDescriptiveStatistics.vtkDescriptiveStatistics_GetG2Kurtosis_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDescriptiveStatistics_GetSignedDeviations_08(HandleRef pThis);

		public virtual int GetSignedDeviations()
		{
			return vtkDescriptiveStatistics.vtkDescriptiveStatistics_GetSignedDeviations_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDescriptiveStatistics_GetUnbiasedVariance_09(HandleRef pThis);

		public virtual int GetUnbiasedVariance()
		{
			return vtkDescriptiveStatistics.vtkDescriptiveStatistics_GetUnbiasedVariance_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDescriptiveStatistics_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDescriptiveStatistics.vtkDescriptiveStatistics_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDescriptiveStatistics_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDescriptiveStatistics.vtkDescriptiveStatistics_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDescriptiveStatistics_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDescriptiveStatistics NewInstance()
		{
			vtkDescriptiveStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDescriptiveStatistics.vtkDescriptiveStatistics_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDescriptiveStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDescriptiveStatistics_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDescriptiveStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkDescriptiveStatistics vtkDescriptiveStatistics = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDescriptiveStatistics.vtkDescriptiveStatistics_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDescriptiveStatistics = (vtkDescriptiveStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDescriptiveStatistics.Register(null);
				}
			}
			return vtkDescriptiveStatistics;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDescriptiveStatistics_SetDeviationParameter_15(HandleRef pThis, string name);

		public void SetDeviationParameter(string name)
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_SetDeviationParameter_15(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDescriptiveStatistics_SetG1Skewness_16(HandleRef pThis, int _arg);

		public virtual void SetG1Skewness(int _arg)
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_SetG1Skewness_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDescriptiveStatistics_SetG2Kurtosis_17(HandleRef pThis, int _arg);

		public virtual void SetG2Kurtosis(int _arg)
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_SetG2Kurtosis_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDescriptiveStatistics_SetNominalParameter_18(HandleRef pThis, string name);

		public void SetNominalParameter(string name)
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_SetNominalParameter_18(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDescriptiveStatistics_SetSignedDeviations_19(HandleRef pThis, int _arg);

		public virtual void SetSignedDeviations(int _arg)
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_SetSignedDeviations_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDescriptiveStatistics_SetUnbiasedVariance_20(HandleRef pThis, int _arg);

		public virtual void SetUnbiasedVariance(int _arg)
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_SetUnbiasedVariance_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDescriptiveStatistics_SignedDeviationsOff_21(HandleRef pThis);

		public virtual void SignedDeviationsOff()
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_SignedDeviationsOff_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDescriptiveStatistics_SignedDeviationsOn_22(HandleRef pThis);

		public virtual void SignedDeviationsOn()
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_SignedDeviationsOn_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDescriptiveStatistics_UnbiasedVarianceOff_23(HandleRef pThis);

		public virtual void UnbiasedVarianceOff()
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_UnbiasedVarianceOff_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDescriptiveStatistics_UnbiasedVarianceOn_24(HandleRef pThis);

		public virtual void UnbiasedVarianceOn()
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_UnbiasedVarianceOn_24(base.GetCppThis());
		}
	}
}
