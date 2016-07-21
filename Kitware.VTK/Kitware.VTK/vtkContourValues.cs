using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkContourValues : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkContourValues";

		public new static readonly string MRClassNameKey;

		static vtkContourValues()
		{
			vtkContourValues.MRClassNameKey = "class vtkContourValues";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContourValues.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourValues"));
		}

		public vtkContourValues(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkContourValues_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContourValues New()
		{
			vtkContourValues result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourValues.vtkContourValues_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourValues)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkContourValues() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkContourValues.vtkContourValues_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkContourValues_GenerateValues_01(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkContourValues.vtkContourValues_GenerateValues_01(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkContourValues_GenerateValues_02(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkContourValues.vtkContourValues_GenerateValues_02(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkContourValues_GetNumberOfContours_03(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkContourValues.vtkContourValues_GetNumberOfContours_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkContourValues_GetValue_04(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkContourValues.vtkContourValues_GetValue_04(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkContourValues_GetValues_05(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkContourValues.vtkContourValues_GetValues_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkContourValues_GetValues_06(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkContourValues.vtkContourValues_GetValues_06(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkContourValues_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkContourValues.vtkContourValues_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkContourValues_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkContourValues.vtkContourValues_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkContourValues_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkContourValues NewInstance()
		{
			vtkContourValues result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourValues.vtkContourValues_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourValues)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkContourValues_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContourValues SafeDownCast(vtkObjectBase o)
		{
			vtkContourValues vtkContourValues = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourValues.vtkContourValues_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourValues = (vtkContourValues)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourValues.Register(null);
				}
			}
			return vtkContourValues;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkContourValues_SetNumberOfContours_12(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkContourValues.vtkContourValues_SetNumberOfContours_12(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkContourValues_SetValue_13(HandleRef pThis, int i, double value);

		public void SetValue(int i, double value)
		{
			vtkContourValues.vtkContourValues_SetValue_13(base.GetCppThis(), i, value);
		}
	}
}
