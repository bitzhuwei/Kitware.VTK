using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDijkstraImageGeodesicPath : vtkDijkstraGraphGeodesicPath
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDijkstraImageGeodesicPath";

		public new static readonly string MRClassNameKey;

		static vtkDijkstraImageGeodesicPath()
		{
			vtkDijkstraImageGeodesicPath.MRClassNameKey = "class vtkDijkstraImageGeodesicPath";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDijkstraImageGeodesicPath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDijkstraImageGeodesicPath"));
		}

		public vtkDijkstraImageGeodesicPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDijkstraImageGeodesicPath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDijkstraImageGeodesicPath New()
		{
			vtkDijkstraImageGeodesicPath result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDijkstraImageGeodesicPath.vtkDijkstraImageGeodesicPath_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDijkstraImageGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDijkstraImageGeodesicPath() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDijkstraImageGeodesicPath.vtkDijkstraImageGeodesicPath_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDijkstraImageGeodesicPath_GetCurvatureWeight_01(HandleRef pThis);

		public virtual double GetCurvatureWeight()
		{
			return vtkDijkstraImageGeodesicPath.vtkDijkstraImageGeodesicPath_GetCurvatureWeight_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDijkstraImageGeodesicPath_GetCurvatureWeightMaxValue_02(HandleRef pThis);

		public virtual double GetCurvatureWeightMaxValue()
		{
			return vtkDijkstraImageGeodesicPath.vtkDijkstraImageGeodesicPath_GetCurvatureWeightMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDijkstraImageGeodesicPath_GetCurvatureWeightMinValue_03(HandleRef pThis);

		public virtual double GetCurvatureWeightMinValue()
		{
			return vtkDijkstraImageGeodesicPath.vtkDijkstraImageGeodesicPath_GetCurvatureWeightMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDijkstraImageGeodesicPath_GetEdgeLengthWeight_04(HandleRef pThis);

		public virtual double GetEdgeLengthWeight()
		{
			return vtkDijkstraImageGeodesicPath.vtkDijkstraImageGeodesicPath_GetEdgeLengthWeight_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDijkstraImageGeodesicPath_GetImageWeight_05(HandleRef pThis);

		public virtual double GetImageWeight()
		{
			return vtkDijkstraImageGeodesicPath.vtkDijkstraImageGeodesicPath_GetImageWeight_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDijkstraImageGeodesicPath_GetInputAsImageData_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetInputAsImageData()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDijkstraImageGeodesicPath.vtkDijkstraImageGeodesicPath_GetInputAsImageData_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDijkstraImageGeodesicPath_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDijkstraImageGeodesicPath.vtkDijkstraImageGeodesicPath_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDijkstraImageGeodesicPath_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDijkstraImageGeodesicPath.vtkDijkstraImageGeodesicPath_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDijkstraImageGeodesicPath_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDijkstraImageGeodesicPath NewInstance()
		{
			vtkDijkstraImageGeodesicPath result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDijkstraImageGeodesicPath.vtkDijkstraImageGeodesicPath_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDijkstraImageGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDijkstraImageGeodesicPath_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDijkstraImageGeodesicPath SafeDownCast(vtkObjectBase o)
		{
			vtkDijkstraImageGeodesicPath vtkDijkstraImageGeodesicPath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDijkstraImageGeodesicPath.vtkDijkstraImageGeodesicPath_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDijkstraImageGeodesicPath = (vtkDijkstraImageGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDijkstraImageGeodesicPath.Register(null);
				}
			}
			return vtkDijkstraImageGeodesicPath;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDijkstraImageGeodesicPath_SetCurvatureWeight_12(HandleRef pThis, double _arg);

		public virtual void SetCurvatureWeight(double _arg)
		{
			vtkDijkstraImageGeodesicPath.vtkDijkstraImageGeodesicPath_SetCurvatureWeight_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDijkstraImageGeodesicPath_SetEdgeLengthWeight_13(HandleRef pThis, double arg0);

		public void SetEdgeLengthWeight(double arg0)
		{
			vtkDijkstraImageGeodesicPath.vtkDijkstraImageGeodesicPath_SetEdgeLengthWeight_13(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDijkstraImageGeodesicPath_SetImageWeight_14(HandleRef pThis, double arg0);

		public void SetImageWeight(double arg0)
		{
			vtkDijkstraImageGeodesicPath.vtkDijkstraImageGeodesicPath_SetImageWeight_14(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDijkstraImageGeodesicPath_SetInput_15(HandleRef pThis, HandleRef arg0);

		public new void SetInput(vtkDataObject arg0)
		{
			vtkDijkstraImageGeodesicPath.vtkDijkstraImageGeodesicPath_SetInput_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
