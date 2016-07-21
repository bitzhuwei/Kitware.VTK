using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTemporalPathLineFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalPathLineFilter";

		public new static readonly string MRClassNameKey;

		static vtkTemporalPathLineFilter()
		{
			vtkTemporalPathLineFilter.MRClassNameKey = "class vtkTemporalPathLineFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalPathLineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalPathLineFilter"));
		}

		public vtkTemporalPathLineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalPathLineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalPathLineFilter New()
		{
			vtkTemporalPathLineFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalPathLineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTemporalPathLineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalPathLineFilter_Flush_01(HandleRef pThis);

		public void Flush()
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_Flush_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalPathLineFilter_GetIdChannelArray_02(HandleRef pThis);

		public virtual string GetIdChannelArray()
		{
			return Marshal.PtrToStringAnsi(vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_GetIdChannelArray_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTemporalPathLineFilter_GetKeepDeadTrails_03(HandleRef pThis);

		public virtual int GetKeepDeadTrails()
		{
			return vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_GetKeepDeadTrails_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTemporalPathLineFilter_GetMaskPoints_04(HandleRef pThis);

		public virtual int GetMaskPoints()
		{
			return vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_GetMaskPoints_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalPathLineFilter_GetMaxStepDistance_05(HandleRef pThis);

		public virtual double[] GetMaxStepDistance()
		{
			IntPtr intPtr = vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_GetMaxStepDistance_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalPathLineFilter_GetMaxStepDistance_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetMaxStepDistance(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_GetMaxStepDistance_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalPathLineFilter_GetMaxStepDistance_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetMaxStepDistance(IntPtr _arg)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_GetMaxStepDistance_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkTemporalPathLineFilter_GetMaxTrackLength_08(HandleRef pThis);

		public virtual uint GetMaxTrackLength()
		{
			return vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_GetMaxTrackLength_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTemporalPathLineFilter_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTemporalPathLineFilter_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalPathLineFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTemporalPathLineFilter NewInstance()
		{
			vtkTemporalPathLineFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalPathLineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalPathLineFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalPathLineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalPathLineFilter vtkTemporalPathLineFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalPathLineFilter = (vtkTemporalPathLineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalPathLineFilter.Register(null);
				}
			}
			return vtkTemporalPathLineFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalPathLineFilter_SetIdChannelArray_14(HandleRef pThis, string _arg);

		public virtual void SetIdChannelArray(string _arg)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SetIdChannelArray_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalPathLineFilter_SetKeepDeadTrails_15(HandleRef pThis, int _arg);

		public virtual void SetKeepDeadTrails(int _arg)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SetKeepDeadTrails_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalPathLineFilter_SetMaskPoints_16(HandleRef pThis, int _arg);

		public virtual void SetMaskPoints(int _arg)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SetMaskPoints_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalPathLineFilter_SetMaxStepDistance_17(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetMaxStepDistance(double _arg1, double _arg2, double _arg3)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SetMaxStepDistance_17(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalPathLineFilter_SetMaxStepDistance_18(HandleRef pThis, IntPtr _arg);

		public virtual void SetMaxStepDistance(IntPtr _arg)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SetMaxStepDistance_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalPathLineFilter_SetMaxTrackLength_19(HandleRef pThis, uint _arg);

		public virtual void SetMaxTrackLength(uint _arg)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SetMaxTrackLength_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalPathLineFilter_SetSelection_20(HandleRef pThis, HandleRef input);

		public void SetSelection(vtkDataSet input)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SetSelection_20(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalPathLineFilter_SetSelectionConnection_21(HandleRef pThis, HandleRef algOutput);

		public void SetSelectionConnection(vtkAlgorithmOutput algOutput)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SetSelectionConnection_21(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}
	}
}
