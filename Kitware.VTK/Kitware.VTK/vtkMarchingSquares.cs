using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMarchingSquares : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMarchingSquares";

		public new static readonly string MRClassNameKey;

		static vtkMarchingSquares()
		{
			vtkMarchingSquares.MRClassNameKey = "class vtkMarchingSquares";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMarchingSquares.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMarchingSquares"));
		}

		public vtkMarchingSquares(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMarchingSquares_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMarchingSquares New()
		{
			vtkMarchingSquares result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMarchingSquares.vtkMarchingSquares_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMarchingSquares)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMarchingSquares() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMarchingSquares.vtkMarchingSquares_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingSquares_CreateDefaultLocator_01(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkMarchingSquares.vtkMarchingSquares_CreateDefaultLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingSquares_GenerateValues_02(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkMarchingSquares.vtkMarchingSquares_GenerateValues_02(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingSquares_GenerateValues_03(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkMarchingSquares.vtkMarchingSquares_GenerateValues_03(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMarchingSquares_GetImageRange_04(HandleRef pThis);

		public virtual int[] GetImageRange()
		{
			IntPtr intPtr = vtkMarchingSquares.vtkMarchingSquares_GetImageRange_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingSquares_GetImageRange_05(HandleRef pThis, IntPtr data);

		public virtual void GetImageRange(IntPtr data)
		{
			vtkMarchingSquares.vtkMarchingSquares_GetImageRange_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMarchingSquares_GetLocator_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMarchingSquares.vtkMarchingSquares_GetLocator_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkMarchingSquares_GetMTime_07(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkMarchingSquares.vtkMarchingSquares_GetMTime_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMarchingSquares_GetNumberOfContours_08(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkMarchingSquares.vtkMarchingSquares_GetNumberOfContours_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMarchingSquares_GetValue_09(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkMarchingSquares.vtkMarchingSquares_GetValue_09(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMarchingSquares_GetValues_10(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkMarchingSquares.vtkMarchingSquares_GetValues_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingSquares_GetValues_11(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkMarchingSquares.vtkMarchingSquares_GetValues_11(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMarchingSquares_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMarchingSquares.vtkMarchingSquares_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMarchingSquares_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMarchingSquares.vtkMarchingSquares_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMarchingSquares_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMarchingSquares NewInstance()
		{
			vtkMarchingSquares result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMarchingSquares.vtkMarchingSquares_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMarchingSquares)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMarchingSquares_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMarchingSquares SafeDownCast(vtkObjectBase o)
		{
			vtkMarchingSquares vtkMarchingSquares = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMarchingSquares.vtkMarchingSquares_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMarchingSquares = (vtkMarchingSquares)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMarchingSquares.Register(null);
				}
			}
			return vtkMarchingSquares;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingSquares_SetImageRange_17(HandleRef pThis, IntPtr data);

		public virtual void SetImageRange(IntPtr data)
		{
			vtkMarchingSquares.vtkMarchingSquares_SetImageRange_17(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingSquares_SetImageRange_18(HandleRef pThis, int imin, int imax, int jmin, int jmax, int kmin, int kmax);

		public void SetImageRange(int imin, int imax, int jmin, int jmax, int kmin, int kmax)
		{
			vtkMarchingSquares.vtkMarchingSquares_SetImageRange_18(base.GetCppThis(), imin, imax, jmin, jmax, kmin, kmax);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingSquares_SetLocator_19(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkMarchingSquares.vtkMarchingSquares_SetLocator_19(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingSquares_SetNumberOfContours_20(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkMarchingSquares.vtkMarchingSquares_SetNumberOfContours_20(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingSquares_SetValue_21(HandleRef pThis, int i, double value);

		public void SetValue(int i, double value)
		{
			vtkMarchingSquares.vtkMarchingSquares_SetValue_21(base.GetCppThis(), i, value);
		}
	}
}
