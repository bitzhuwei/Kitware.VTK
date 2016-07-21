using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOrderStatistics : vtkUnivariateStatisticsAlgorithm
	{
		public enum QuantileDefinitionType
		{
			InverseCDF,
			InverseCDFAveragedSteps
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkOrderStatistics";

		public new static readonly string MRClassNameKey;

		static vtkOrderStatistics()
		{
			vtkOrderStatistics.MRClassNameKey = "class vtkOrderStatistics";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOrderStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrderStatistics"));
		}

		public vtkOrderStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkOrderStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOrderStatistics New()
		{
			vtkOrderStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrderStatistics.vtkOrderStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrderStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOrderStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOrderStatistics.vtkOrderStatistics_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkOrderStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkOrderStatistics.vtkOrderStatistics_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkOrderStatistics_GetNumberOfIntervals_02(HandleRef pThis);

		public virtual long GetNumberOfIntervals()
		{
			return vtkOrderStatistics.vtkOrderStatistics_GetNumberOfIntervals_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkOrderStatistics_GetNumericType_03(HandleRef pThis);

		public virtual int GetNumericType()
		{
			return vtkOrderStatistics.vtkOrderStatistics_GetNumericType_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkOrderStatistics_GetQuantileDefinition_04(HandleRef pThis);

		public long GetQuantileDefinition()
		{
			return vtkOrderStatistics.vtkOrderStatistics_GetQuantileDefinition_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkOrderStatistics_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOrderStatistics.vtkOrderStatistics_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkOrderStatistics_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOrderStatistics.vtkOrderStatistics_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkOrderStatistics_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOrderStatistics NewInstance()
		{
			vtkOrderStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrderStatistics.vtkOrderStatistics_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrderStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkOrderStatistics_NumericTypeOff_09(HandleRef pThis);

		public virtual void NumericTypeOff()
		{
			vtkOrderStatistics.vtkOrderStatistics_NumericTypeOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkOrderStatistics_NumericTypeOn_10(HandleRef pThis);

		public virtual void NumericTypeOn()
		{
			vtkOrderStatistics.vtkOrderStatistics_NumericTypeOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkOrderStatistics_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOrderStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkOrderStatistics vtkOrderStatistics = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrderStatistics.vtkOrderStatistics_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOrderStatistics = (vtkOrderStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOrderStatistics.Register(null);
				}
			}
			return vtkOrderStatistics;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkOrderStatistics_SetNumberOfIntervals_12(HandleRef pThis, long _arg);

		public virtual void SetNumberOfIntervals(long _arg)
		{
			vtkOrderStatistics.vtkOrderStatistics_SetNumberOfIntervals_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkOrderStatistics_SetNumericType_13(HandleRef pThis, int _arg);

		public virtual void SetNumericType(int _arg)
		{
			vtkOrderStatistics.vtkOrderStatistics_SetNumericType_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkOrderStatistics_SetQuantileDefinition_14(HandleRef pThis, vtkOrderStatistics.QuantileDefinitionType _arg);

		public virtual void SetQuantileDefinition(vtkOrderStatistics.QuantileDefinitionType _arg)
		{
			vtkOrderStatistics.vtkOrderStatistics_SetQuantileDefinition_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkOrderStatistics_SetQuantileDefinition_15(HandleRef pThis, int arg0);

		public void SetQuantileDefinition(int arg0)
		{
			vtkOrderStatistics.vtkOrderStatistics_SetQuantileDefinition_15(base.GetCppThis(), arg0);
		}
	}
}
