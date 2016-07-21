using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkProStarReader : vtkUnstructuredGridAlgorithm
	{
		public enum cellType
		{
			starcdBaffleType = 3,
			starcdFluidType = 1,
			starcdLineType = 5,
			starcdPointType,
			starcdShellType = 4,
			starcdSolidType = 2
		}

		public enum shapeType
		{
			starcdHex = 11,
			starcdLine = 2,
			starcdPoint = 1,
			starcdPoly = 255,
			starcdPrism = 12,
			starcdPyr = 14,
			starcdShell = 3,
			starcdTet = 13
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkProStarReader";

		public new static readonly string MRClassNameKey;

		static vtkProStarReader()
		{
			vtkProStarReader.MRClassNameKey = "class vtkProStarReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProStarReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProStarReader"));
		}

		public vtkProStarReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkProStarReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProStarReader New()
		{
			vtkProStarReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProStarReader.vtkProStarReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProStarReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkProStarReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkProStarReader.vtkProStarReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkProStarReader_GetFileName_01(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkProStarReader.vtkProStarReader_GetFileName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkProStarReader_GetScaleFactor_02(HandleRef pThis);

		public virtual double GetScaleFactor()
		{
			return vtkProStarReader.vtkProStarReader_GetScaleFactor_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkProStarReader_GetScaleFactorMaxValue_03(HandleRef pThis);

		public virtual double GetScaleFactorMaxValue()
		{
			return vtkProStarReader.vtkProStarReader_GetScaleFactorMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkProStarReader_GetScaleFactorMinValue_04(HandleRef pThis);

		public virtual double GetScaleFactorMinValue()
		{
			return vtkProStarReader.vtkProStarReader_GetScaleFactorMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkProStarReader_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProStarReader.vtkProStarReader_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkProStarReader_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProStarReader.vtkProStarReader_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkProStarReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProStarReader NewInstance()
		{
			vtkProStarReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProStarReader.vtkProStarReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProStarReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkProStarReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProStarReader SafeDownCast(vtkObjectBase o)
		{
			vtkProStarReader vtkProStarReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProStarReader.vtkProStarReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProStarReader = (vtkProStarReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProStarReader.Register(null);
				}
			}
			return vtkProStarReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkProStarReader_SetFileName_10(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkProStarReader.vtkProStarReader_SetFileName_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkProStarReader_SetScaleFactor_11(HandleRef pThis, double _arg);

		public virtual void SetScaleFactor(double _arg)
		{
			vtkProStarReader.vtkProStarReader_SetScaleFactor_11(base.GetCppThis(), _arg);
		}
	}
}
