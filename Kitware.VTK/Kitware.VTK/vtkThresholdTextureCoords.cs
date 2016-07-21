using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkThresholdTextureCoords : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkThresholdTextureCoords";

		public new static readonly string MRClassNameKey;

		static vtkThresholdTextureCoords()
		{
			vtkThresholdTextureCoords.MRClassNameKey = "class vtkThresholdTextureCoords";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThresholdTextureCoords.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThresholdTextureCoords"));
		}

		public vtkThresholdTextureCoords(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkThresholdTextureCoords_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThresholdTextureCoords New()
		{
			vtkThresholdTextureCoords result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThresholdTextureCoords.vtkThresholdTextureCoords_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThresholdTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkThresholdTextureCoords() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkThresholdTextureCoords.vtkThresholdTextureCoords_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkThresholdTextureCoords_GetInTextureCoord_01(HandleRef pThis);

		public virtual double[] GetInTextureCoord()
		{
			IntPtr intPtr = vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetInTextureCoord_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThresholdTextureCoords_GetInTextureCoord_02(HandleRef pThis, IntPtr data);

		public virtual void GetInTextureCoord(IntPtr data)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetInTextureCoord_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkThresholdTextureCoords_GetLowerThreshold_03(HandleRef pThis);

		public virtual double GetLowerThreshold()
		{
			return vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetLowerThreshold_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkThresholdTextureCoords_GetOutTextureCoord_04(HandleRef pThis);

		public virtual double[] GetOutTextureCoord()
		{
			IntPtr intPtr = vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetOutTextureCoord_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThresholdTextureCoords_GetOutTextureCoord_05(HandleRef pThis, IntPtr data);

		public virtual void GetOutTextureCoord(IntPtr data)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetOutTextureCoord_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThresholdTextureCoords_GetTextureDimension_06(HandleRef pThis);

		public virtual int GetTextureDimension()
		{
			return vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetTextureDimension_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThresholdTextureCoords_GetTextureDimensionMaxValue_07(HandleRef pThis);

		public virtual int GetTextureDimensionMaxValue()
		{
			return vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetTextureDimensionMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThresholdTextureCoords_GetTextureDimensionMinValue_08(HandleRef pThis);

		public virtual int GetTextureDimensionMinValue()
		{
			return vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetTextureDimensionMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkThresholdTextureCoords_GetUpperThreshold_09(HandleRef pThis);

		public virtual double GetUpperThreshold()
		{
			return vtkThresholdTextureCoords.vtkThresholdTextureCoords_GetUpperThreshold_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThresholdTextureCoords_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkThresholdTextureCoords.vtkThresholdTextureCoords_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThresholdTextureCoords_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkThresholdTextureCoords.vtkThresholdTextureCoords_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkThresholdTextureCoords_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkThresholdTextureCoords NewInstance()
		{
			vtkThresholdTextureCoords result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThresholdTextureCoords.vtkThresholdTextureCoords_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThresholdTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkThresholdTextureCoords_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThresholdTextureCoords SafeDownCast(vtkObjectBase o)
		{
			vtkThresholdTextureCoords vtkThresholdTextureCoords = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThresholdTextureCoords.vtkThresholdTextureCoords_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThresholdTextureCoords = (vtkThresholdTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThresholdTextureCoords.Register(null);
				}
			}
			return vtkThresholdTextureCoords;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThresholdTextureCoords_SetInTextureCoord_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetInTextureCoord(double _arg1, double _arg2, double _arg3)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_SetInTextureCoord_15(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThresholdTextureCoords_SetInTextureCoord_16(HandleRef pThis, IntPtr _arg);

		public virtual void SetInTextureCoord(IntPtr _arg)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_SetInTextureCoord_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThresholdTextureCoords_SetOutTextureCoord_17(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOutTextureCoord(double _arg1, double _arg2, double _arg3)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_SetOutTextureCoord_17(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThresholdTextureCoords_SetOutTextureCoord_18(HandleRef pThis, IntPtr _arg);

		public virtual void SetOutTextureCoord(IntPtr _arg)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_SetOutTextureCoord_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThresholdTextureCoords_SetTextureDimension_19(HandleRef pThis, int _arg);

		public virtual void SetTextureDimension(int _arg)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_SetTextureDimension_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThresholdTextureCoords_ThresholdBetween_20(HandleRef pThis, double lower, double upper);

		public void ThresholdBetween(double lower, double upper)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_ThresholdBetween_20(base.GetCppThis(), lower, upper);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThresholdTextureCoords_ThresholdByLower_21(HandleRef pThis, double lower);

		public void ThresholdByLower(double lower)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_ThresholdByLower_21(base.GetCppThis(), lower);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThresholdTextureCoords_ThresholdByUpper_22(HandleRef pThis, double upper);

		public void ThresholdByUpper(double upper)
		{
			vtkThresholdTextureCoords.vtkThresholdTextureCoords_ThresholdByUpper_22(base.GetCppThis(), upper);
		}
	}
}
