using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkColorSeries : vtkObject
	{
		public enum BLUES_WrapperEnum
		{
			BLUES = 3,
			CITRUS = 5,
			COOL = 2,
			CUSTOM = 6,
			SPECTRUM = 0,
			WARM,
			WILD_FLOWER = 4
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkColorSeries";

		public new static readonly string MRClassNameKey;

		static vtkColorSeries()
		{
			vtkColorSeries.MRClassNameKey = "class vtkColorSeries";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkColorSeries.MRClassNameKey, Type.GetType("Kitware.VTK.vtkColorSeries"));
		}

		public vtkColorSeries(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkColorSeries_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkColorSeries New()
		{
			vtkColorSeries result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorSeries.vtkColorSeries_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorSeries)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkColorSeries() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkColorSeries.vtkColorSeries_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkColorSeries_ClearColors_01(HandleRef pThis);

		public void ClearColors()
		{
			vtkColorSeries.vtkColorSeries_ClearColors_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkColorSeries_DeepCopy_02(HandleRef pThis, HandleRef chartColors);

		public void DeepCopy(vtkColorSeries chartColors)
		{
			vtkColorSeries.vtkColorSeries_DeepCopy_02(base.GetCppThis(), (chartColors == null) ? default(HandleRef) : chartColors.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkColorSeries_GetColorScheme_03(HandleRef pThis);

		public virtual int GetColorScheme()
		{
			return vtkColorSeries.vtkColorSeries_GetColorScheme_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkColorSeries_GetNumberOfColors_04(HandleRef pThis);

		public int GetNumberOfColors()
		{
			return vtkColorSeries.vtkColorSeries_GetNumberOfColors_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkColorSeries_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkColorSeries.vtkColorSeries_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkColorSeries_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkColorSeries.vtkColorSeries_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkColorSeries_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkColorSeries NewInstance()
		{
			vtkColorSeries result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorSeries.vtkColorSeries_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorSeries)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkColorSeries_RemoveColor_09(HandleRef pThis, int index);

		public void RemoveColor(int index)
		{
			vtkColorSeries.vtkColorSeries_RemoveColor_09(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkColorSeries_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkColorSeries SafeDownCast(vtkObjectBase o)
		{
			vtkColorSeries vtkColorSeries = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorSeries.vtkColorSeries_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorSeries = (vtkColorSeries)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorSeries.Register(null);
				}
			}
			return vtkColorSeries;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkColorSeries_SetColorScheme_11(HandleRef pThis, int scheme);

		public void SetColorScheme(int scheme)
		{
			vtkColorSeries.vtkColorSeries_SetColorScheme_11(base.GetCppThis(), scheme);
		}
	}
}
