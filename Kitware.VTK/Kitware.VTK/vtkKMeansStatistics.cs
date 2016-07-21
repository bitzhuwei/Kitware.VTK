using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkKMeansStatistics : vtkStatisticsAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkKMeansStatistics";

		public new static readonly string MRClassNameKey;

		static vtkKMeansStatistics()
		{
			vtkKMeansStatistics.MRClassNameKey = "class vtkKMeansStatistics";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKMeansStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKMeansStatistics"));
		}

		public vtkKMeansStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkKMeansStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkKMeansStatistics New()
		{
			vtkKMeansStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKMeansStatistics.vtkKMeansStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKMeansStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkKMeansStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkKMeansStatistics.vtkKMeansStatistics_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkKMeansStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkKMeansStatistics.vtkKMeansStatistics_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkKMeansStatistics_GetDefaultNumberOfClusters_02(HandleRef pThis);

		public virtual int GetDefaultNumberOfClusters()
		{
			return vtkKMeansStatistics.vtkKMeansStatistics_GetDefaultNumberOfClusters_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkKMeansStatistics_GetDistanceFunctor_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkKMeansDistanceFunctor GetDistanceFunctor()
		{
			vtkKMeansDistanceFunctor vtkKMeansDistanceFunctor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKMeansStatistics.vtkKMeansStatistics_GetDistanceFunctor_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKMeansDistanceFunctor = (vtkKMeansDistanceFunctor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKMeansDistanceFunctor.Register(null);
				}
			}
			return vtkKMeansDistanceFunctor;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkKMeansStatistics_GetKValuesArrayName_04(HandleRef pThis);

		public virtual string GetKValuesArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkKMeansStatistics.vtkKMeansStatistics_GetKValuesArrayName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkKMeansStatistics_GetMaxNumIterations_05(HandleRef pThis);

		public virtual int GetMaxNumIterations()
		{
			return vtkKMeansStatistics.vtkKMeansStatistics_GetMaxNumIterations_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkKMeansStatistics_GetTolerance_06(HandleRef pThis);

		public virtual double GetTolerance()
		{
			return vtkKMeansStatistics.vtkKMeansStatistics_GetTolerance_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkKMeansStatistics_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkKMeansStatistics.vtkKMeansStatistics_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkKMeansStatistics_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkKMeansStatistics.vtkKMeansStatistics_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkKMeansStatistics_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkKMeansStatistics NewInstance()
		{
			vtkKMeansStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKMeansStatistics.vtkKMeansStatistics_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKMeansStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkKMeansStatistics_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkKMeansStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkKMeansStatistics vtkKMeansStatistics = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKMeansStatistics.vtkKMeansStatistics_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKMeansStatistics = (vtkKMeansStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKMeansStatistics.Register(null);
				}
			}
			return vtkKMeansStatistics;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkKMeansStatistics_SetDefaultNumberOfClusters_12(HandleRef pThis, int _arg);

		public virtual void SetDefaultNumberOfClusters(int _arg)
		{
			vtkKMeansStatistics.vtkKMeansStatistics_SetDefaultNumberOfClusters_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkKMeansStatistics_SetDistanceFunctor_13(HandleRef pThis, HandleRef arg0);

		public virtual void SetDistanceFunctor(vtkKMeansDistanceFunctor arg0)
		{
			vtkKMeansStatistics.vtkKMeansStatistics_SetDistanceFunctor_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkKMeansStatistics_SetKValuesArrayName_14(HandleRef pThis, string _arg);

		public virtual void SetKValuesArrayName(string _arg)
		{
			vtkKMeansStatistics.vtkKMeansStatistics_SetKValuesArrayName_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkKMeansStatistics_SetMaxNumIterations_15(HandleRef pThis, int _arg);

		public virtual void SetMaxNumIterations(int _arg)
		{
			vtkKMeansStatistics.vtkKMeansStatistics_SetMaxNumIterations_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkKMeansStatistics_SetTolerance_16(HandleRef pThis, double _arg);

		public virtual void SetTolerance(double _arg)
		{
			vtkKMeansStatistics.vtkKMeansStatistics_SetTolerance_16(base.GetCppThis(), _arg);
		}
	}
}
