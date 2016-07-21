using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkScalarsToColors : vtkObject
	{
		public enum VectorModes
		{
			COMPONENT = 1,
			MAGNITUDE = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkScalarsToColors";

		public new static readonly string MRClassNameKey;

		static vtkScalarsToColors()
		{
			vtkScalarsToColors.MRClassNameKey = "class vtkScalarsToColors";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScalarsToColors.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarsToColors"));
		}

		public vtkScalarsToColors(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkScalarsToColors_Build_01(HandleRef pThis);

		public virtual void Build()
		{
			vtkScalarsToColors.vtkScalarsToColors_Build_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarsToColors_ConvertUnsignedCharToRGBA_02(HandleRef pThis, HandleRef colors, int numComp, int numTuples, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkUnsignedCharArray ConvertUnsignedCharToRGBA(vtkUnsignedCharArray colors, int numComp, int numTuples)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarsToColors.vtkScalarsToColors_ConvertUnsignedCharToRGBA_02(base.GetCppThis(), (colors == null) ? default(HandleRef) : colors.GetCppThis(), numComp, numTuples, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkScalarsToColors_GetAlpha_03(HandleRef pThis);

		public virtual double GetAlpha()
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetAlpha_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkScalarsToColors_GetColor_04(HandleRef pThis, double v, IntPtr rgb);

		public virtual void GetColor(double v, IntPtr rgb)
		{
			vtkScalarsToColors.vtkScalarsToColors_GetColor_04(base.GetCppThis(), v, rgb);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarsToColors_GetColor_05(HandleRef pThis, double v);

		public double[] GetColor(double v)
		{
			IntPtr intPtr = vtkScalarsToColors.vtkScalarsToColors_GetColor_05(base.GetCppThis(), v);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkScalarsToColors_GetLuminance_06(HandleRef pThis, double x);

		public double GetLuminance(double x)
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetLuminance_06(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkScalarsToColors_GetNumberOfAvailableColors_07(HandleRef pThis);

		public virtual long GetNumberOfAvailableColors()
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetNumberOfAvailableColors_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkScalarsToColors_GetOpacity_08(HandleRef pThis, double arg0);

		public virtual double GetOpacity(double arg0)
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetOpacity_08(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarsToColors_GetRange_09(HandleRef pThis);

		public virtual double[] GetRange()
		{
			IntPtr intPtr = vtkScalarsToColors.vtkScalarsToColors_GetRange_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkScalarsToColors_GetVectorComponent_10(HandleRef pThis);

		public virtual int GetVectorComponent()
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetVectorComponent_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkScalarsToColors_GetVectorMode_11(HandleRef pThis);

		public virtual int GetVectorMode()
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetVectorMode_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkScalarsToColors_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkScalarsToColors.vtkScalarsToColors_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkScalarsToColors_IsOpaque_13(HandleRef pThis);

		public virtual int IsOpaque()
		{
			return vtkScalarsToColors.vtkScalarsToColors_IsOpaque_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkScalarsToColors_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkScalarsToColors.vtkScalarsToColors_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarsToColors_MapScalars_15(HandleRef pThis, HandleRef scalars, int colorMode, int component, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkUnsignedCharArray MapScalars(vtkDataArray scalars, int colorMode, int component)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarsToColors.vtkScalarsToColors_MapScalars_15(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), colorMode, component, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkScalarsToColors_MapScalarsThroughTable_16(HandleRef pThis, HandleRef scalars, IntPtr output, int outputFormat);

		public void MapScalarsThroughTable(vtkDataArray scalars, IntPtr output, int outputFormat)
		{
			vtkScalarsToColors.vtkScalarsToColors_MapScalarsThroughTable_16(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), output, outputFormat);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkScalarsToColors_MapScalarsThroughTable_17(HandleRef pThis, HandleRef scalars, IntPtr output);

		public void MapScalarsThroughTable(vtkDataArray scalars, IntPtr output)
		{
			vtkScalarsToColors.vtkScalarsToColors_MapScalarsThroughTable_17(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), output);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkScalarsToColors_MapScalarsThroughTable2_18(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat);

		public virtual void MapScalarsThroughTable2(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
		{
			vtkScalarsToColors.vtkScalarsToColors_MapScalarsThroughTable2_18(base.GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarsToColors_MapValue_19(HandleRef pThis, double v);

		public virtual IntPtr MapValue(double v)
		{
			return vtkScalarsToColors.vtkScalarsToColors_MapValue_19(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarsToColors_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkScalarsToColors NewInstance()
		{
			vtkScalarsToColors result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarsToColors.vtkScalarsToColors_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarsToColors_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkScalarsToColors SafeDownCast(vtkObjectBase o)
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarsToColors.vtkScalarsToColors_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkScalarsToColors_SetAlpha_22(HandleRef pThis, double alpha);

		public virtual void SetAlpha(double alpha)
		{
			vtkScalarsToColors.vtkScalarsToColors_SetAlpha_22(base.GetCppThis(), alpha);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkScalarsToColors_SetRange_23(HandleRef pThis, double min, double max);

		public virtual void SetRange(double min, double max)
		{
			vtkScalarsToColors.vtkScalarsToColors_SetRange_23(base.GetCppThis(), min, max);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkScalarsToColors_SetRange_24(HandleRef pThis, IntPtr rng);

		public void SetRange(IntPtr rng)
		{
			vtkScalarsToColors.vtkScalarsToColors_SetRange_24(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkScalarsToColors_SetVectorComponent_25(HandleRef pThis, int _arg);

		public virtual void SetVectorComponent(int _arg)
		{
			vtkScalarsToColors.vtkScalarsToColors_SetVectorComponent_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkScalarsToColors_SetVectorMode_26(HandleRef pThis, int _arg);

		public virtual void SetVectorMode(int _arg)
		{
			vtkScalarsToColors.vtkScalarsToColors_SetVectorMode_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkScalarsToColors_SetVectorModeToComponent_27(HandleRef pThis);

		public void SetVectorModeToComponent()
		{
			vtkScalarsToColors.vtkScalarsToColors_SetVectorModeToComponent_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkScalarsToColors_SetVectorModeToMagnitude_28(HandleRef pThis);

		public void SetVectorModeToMagnitude()
		{
			vtkScalarsToColors.vtkScalarsToColors_SetVectorModeToMagnitude_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkScalarsToColors_UsingLogScale_29(HandleRef pThis);

		public virtual int UsingLogScale()
		{
			return vtkScalarsToColors.vtkScalarsToColors_UsingLogScale_29(base.GetCppThis());
		}
	}
}
