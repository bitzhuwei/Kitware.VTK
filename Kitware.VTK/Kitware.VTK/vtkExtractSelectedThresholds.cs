using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractSelectedThresholds : vtkExtractSelectionBase
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedThresholds";

		public new static readonly string MRClassNameKey;

		static vtkExtractSelectedThresholds()
		{
			vtkExtractSelectedThresholds.MRClassNameKey = "class vtkExtractSelectedThresholds";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedThresholds.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedThresholds"));
		}

		public vtkExtractSelectedThresholds(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedThresholds_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectedThresholds New()
		{
			vtkExtractSelectedThresholds result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedThresholds)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractSelectedThresholds() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedThresholds_EvaluateValue_01(HandleRef scalars, long id, HandleRef lims);

		public static int EvaluateValue(vtkDataArray scalars, long id, vtkDataArray lims)
		{
			return vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_EvaluateValue_01((scalars == null) ? default(HandleRef) : scalars.GetCppThis(), id, (lims == null) ? default(HandleRef) : lims.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedThresholds_EvaluateValue_02(HandleRef array, int array_component_no, long id, HandleRef lims);

		public static int EvaluateValue(vtkDataArray array, int array_component_no, long id, vtkDataArray lims)
		{
			return vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_EvaluateValue_02((array == null) ? default(HandleRef) : array.GetCppThis(), array_component_no, id, (lims == null) ? default(HandleRef) : lims.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedThresholds_EvaluateValue_03(HandleRef scalars, long id, HandleRef lims, IntPtr AboveCount, IntPtr BelowCount, IntPtr InsideCount);

		public static int EvaluateValue(vtkDataArray scalars, long id, vtkDataArray lims, IntPtr AboveCount, IntPtr BelowCount, IntPtr InsideCount)
		{
			return vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_EvaluateValue_03((scalars == null) ? default(HandleRef) : scalars.GetCppThis(), id, (lims == null) ? default(HandleRef) : lims.GetCppThis(), AboveCount, BelowCount, InsideCount);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedThresholds_EvaluateValue_04(HandleRef scalars, int array_component_no, long id, HandleRef lims, IntPtr AboveCount, IntPtr BelowCount, IntPtr InsideCount);

		public static int EvaluateValue(vtkDataArray scalars, int array_component_no, long id, vtkDataArray lims, IntPtr AboveCount, IntPtr BelowCount, IntPtr InsideCount)
		{
			return vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_EvaluateValue_04((scalars == null) ? default(HandleRef) : scalars.GetCppThis(), array_component_no, id, (lims == null) ? default(HandleRef) : lims.GetCppThis(), AboveCount, BelowCount, InsideCount);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedThresholds_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedThresholds_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedThresholds_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractSelectedThresholds NewInstance()
		{
			vtkExtractSelectedThresholds result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedThresholds)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedThresholds_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectedThresholds SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedThresholds vtkExtractSelectedThresholds = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedThresholds = (vtkExtractSelectedThresholds)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedThresholds.Register(null);
				}
			}
			return vtkExtractSelectedThresholds;
		}
	}
}
