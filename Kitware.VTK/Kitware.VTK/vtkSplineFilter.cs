using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSplineFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSplineFilter";

		public new static readonly string MRClassNameKey;

		static vtkSplineFilter()
		{
			vtkSplineFilter.MRClassNameKey = "class vtkSplineFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSplineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplineFilter"));
		}

		public vtkSplineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSplineFilter New()
		{
			vtkSplineFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineFilter.vtkSplineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSplineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSplineFilter.vtkSplineFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSplineFilter_GetGenerateTCoords_01(HandleRef pThis);

		public virtual int GetGenerateTCoords()
		{
			return vtkSplineFilter.vtkSplineFilter_GetGenerateTCoords_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineFilter_GetGenerateTCoordsAsString_02(HandleRef pThis);

		public string GetGenerateTCoordsAsString()
		{
			return Marshal.PtrToStringAnsi(vtkSplineFilter.vtkSplineFilter_GetGenerateTCoordsAsString_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSplineFilter_GetGenerateTCoordsMaxValue_03(HandleRef pThis);

		public virtual int GetGenerateTCoordsMaxValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetGenerateTCoordsMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSplineFilter_GetGenerateTCoordsMinValue_04(HandleRef pThis);

		public virtual int GetGenerateTCoordsMinValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetGenerateTCoordsMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSplineFilter_GetLength_05(HandleRef pThis);

		public virtual double GetLength()
		{
			return vtkSplineFilter.vtkSplineFilter_GetLength_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSplineFilter_GetLengthMaxValue_06(HandleRef pThis);

		public virtual double GetLengthMaxValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetLengthMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSplineFilter_GetLengthMinValue_07(HandleRef pThis);

		public virtual double GetLengthMinValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetLengthMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSplineFilter_GetMaximumNumberOfSubdivisions_08(HandleRef pThis);

		public virtual int GetMaximumNumberOfSubdivisions()
		{
			return vtkSplineFilter.vtkSplineFilter_GetMaximumNumberOfSubdivisions_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSplineFilter_GetMaximumNumberOfSubdivisionsMaxValue_09(HandleRef pThis);

		public virtual int GetMaximumNumberOfSubdivisionsMaxValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetMaximumNumberOfSubdivisionsMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSplineFilter_GetMaximumNumberOfSubdivisionsMinValue_10(HandleRef pThis);

		public virtual int GetMaximumNumberOfSubdivisionsMinValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetMaximumNumberOfSubdivisionsMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSplineFilter_GetNumberOfSubdivisions_11(HandleRef pThis);

		public virtual int GetNumberOfSubdivisions()
		{
			return vtkSplineFilter.vtkSplineFilter_GetNumberOfSubdivisions_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSplineFilter_GetNumberOfSubdivisionsMaxValue_12(HandleRef pThis);

		public virtual int GetNumberOfSubdivisionsMaxValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetNumberOfSubdivisionsMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSplineFilter_GetNumberOfSubdivisionsMinValue_13(HandleRef pThis);

		public virtual int GetNumberOfSubdivisionsMinValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetNumberOfSubdivisionsMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineFilter_GetSpline_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSpline GetSpline()
		{
			vtkSpline vtkSpline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineFilter.vtkSplineFilter_GetSpline_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpline = (vtkSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpline.Register(null);
				}
			}
			return vtkSpline;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSplineFilter_GetSubdivide_15(HandleRef pThis);

		public virtual int GetSubdivide()
		{
			return vtkSplineFilter.vtkSplineFilter_GetSubdivide_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineFilter_GetSubdivideAsString_16(HandleRef pThis);

		public string GetSubdivideAsString()
		{
			return Marshal.PtrToStringAnsi(vtkSplineFilter.vtkSplineFilter_GetSubdivideAsString_16(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSplineFilter_GetSubdivideMaxValue_17(HandleRef pThis);

		public virtual int GetSubdivideMaxValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetSubdivideMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSplineFilter_GetSubdivideMinValue_18(HandleRef pThis);

		public virtual int GetSubdivideMinValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetSubdivideMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSplineFilter_GetTextureLength_19(HandleRef pThis);

		public virtual double GetTextureLength()
		{
			return vtkSplineFilter.vtkSplineFilter_GetTextureLength_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSplineFilter_GetTextureLengthMaxValue_20(HandleRef pThis);

		public virtual double GetTextureLengthMaxValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetTextureLengthMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSplineFilter_GetTextureLengthMinValue_21(HandleRef pThis);

		public virtual double GetTextureLengthMinValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetTextureLengthMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSplineFilter_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSplineFilter.vtkSplineFilter_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSplineFilter_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSplineFilter.vtkSplineFilter_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineFilter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSplineFilter NewInstance()
		{
			vtkSplineFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineFilter.vtkSplineFilter_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSplineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkSplineFilter vtkSplineFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineFilter.vtkSplineFilter_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSplineFilter = (vtkSplineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSplineFilter.Register(null);
				}
			}
			return vtkSplineFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplineFilter_SetGenerateTCoords_27(HandleRef pThis, int _arg);

		public virtual void SetGenerateTCoords(int _arg)
		{
			vtkSplineFilter.vtkSplineFilter_SetGenerateTCoords_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplineFilter_SetGenerateTCoordsToNormalizedLength_28(HandleRef pThis);

		public void SetGenerateTCoordsToNormalizedLength()
		{
			vtkSplineFilter.vtkSplineFilter_SetGenerateTCoordsToNormalizedLength_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplineFilter_SetGenerateTCoordsToOff_29(HandleRef pThis);

		public void SetGenerateTCoordsToOff()
		{
			vtkSplineFilter.vtkSplineFilter_SetGenerateTCoordsToOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplineFilter_SetGenerateTCoordsToUseLength_30(HandleRef pThis);

		public void SetGenerateTCoordsToUseLength()
		{
			vtkSplineFilter.vtkSplineFilter_SetGenerateTCoordsToUseLength_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplineFilter_SetGenerateTCoordsToUseScalars_31(HandleRef pThis);

		public void SetGenerateTCoordsToUseScalars()
		{
			vtkSplineFilter.vtkSplineFilter_SetGenerateTCoordsToUseScalars_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplineFilter_SetLength_32(HandleRef pThis, double _arg);

		public virtual void SetLength(double _arg)
		{
			vtkSplineFilter.vtkSplineFilter_SetLength_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplineFilter_SetMaximumNumberOfSubdivisions_33(HandleRef pThis, int _arg);

		public virtual void SetMaximumNumberOfSubdivisions(int _arg)
		{
			vtkSplineFilter.vtkSplineFilter_SetMaximumNumberOfSubdivisions_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplineFilter_SetNumberOfSubdivisions_34(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSubdivisions(int _arg)
		{
			vtkSplineFilter.vtkSplineFilter_SetNumberOfSubdivisions_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplineFilter_SetSpline_35(HandleRef pThis, HandleRef arg0);

		public virtual void SetSpline(vtkSpline arg0)
		{
			vtkSplineFilter.vtkSplineFilter_SetSpline_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplineFilter_SetSubdivide_36(HandleRef pThis, int _arg);

		public virtual void SetSubdivide(int _arg)
		{
			vtkSplineFilter.vtkSplineFilter_SetSubdivide_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplineFilter_SetSubdivideToLength_37(HandleRef pThis);

		public void SetSubdivideToLength()
		{
			vtkSplineFilter.vtkSplineFilter_SetSubdivideToLength_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplineFilter_SetSubdivideToSpecified_38(HandleRef pThis);

		public void SetSubdivideToSpecified()
		{
			vtkSplineFilter.vtkSplineFilter_SetSubdivideToSpecified_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplineFilter_SetTextureLength_39(HandleRef pThis, double _arg);

		public virtual void SetTextureLength(double _arg)
		{
			vtkSplineFilter.vtkSplineFilter_SetTextureLength_39(base.GetCppThis(), _arg);
		}
	}
}
