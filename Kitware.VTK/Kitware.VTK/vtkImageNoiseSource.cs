using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageNoiseSource : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageNoiseSource";

		public new static readonly string MRClassNameKey;

		static vtkImageNoiseSource()
		{
			vtkImageNoiseSource.MRClassNameKey = "class vtkImageNoiseSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageNoiseSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageNoiseSource"));
		}

		public vtkImageNoiseSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageNoiseSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageNoiseSource New()
		{
			vtkImageNoiseSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageNoiseSource.vtkImageNoiseSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageNoiseSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageNoiseSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageNoiseSource.vtkImageNoiseSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageNoiseSource_GetMaximum_01(HandleRef pThis);

		public virtual double GetMaximum()
		{
			return vtkImageNoiseSource.vtkImageNoiseSource_GetMaximum_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageNoiseSource_GetMinimum_02(HandleRef pThis);

		public virtual double GetMinimum()
		{
			return vtkImageNoiseSource.vtkImageNoiseSource_GetMinimum_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageNoiseSource_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageNoiseSource.vtkImageNoiseSource_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageNoiseSource_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageNoiseSource.vtkImageNoiseSource_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageNoiseSource_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageNoiseSource NewInstance()
		{
			vtkImageNoiseSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageNoiseSource.vtkImageNoiseSource_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageNoiseSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageNoiseSource_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageNoiseSource SafeDownCast(vtkObjectBase o)
		{
			vtkImageNoiseSource vtkImageNoiseSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageNoiseSource.vtkImageNoiseSource_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageNoiseSource = (vtkImageNoiseSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageNoiseSource.Register(null);
				}
			}
			return vtkImageNoiseSource;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageNoiseSource_SetMaximum_08(HandleRef pThis, double _arg);

		public virtual void SetMaximum(double _arg)
		{
			vtkImageNoiseSource.vtkImageNoiseSource_SetMaximum_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageNoiseSource_SetMinimum_09(HandleRef pThis, double _arg);

		public virtual void SetMinimum(double _arg)
		{
			vtkImageNoiseSource.vtkImageNoiseSource_SetMinimum_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageNoiseSource_SetWholeExtent_10(HandleRef pThis, int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax);

		public void SetWholeExtent(int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax)
		{
			vtkImageNoiseSource.vtkImageNoiseSource_SetWholeExtent_10(base.GetCppThis(), xMinx, xMax, yMin, yMax, zMin, zMax);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageNoiseSource_SetWholeExtent_11(HandleRef pThis, IntPtr ext);

		public void SetWholeExtent(IntPtr ext)
		{
			vtkImageNoiseSource.vtkImageNoiseSource_SetWholeExtent_11(base.GetCppThis(), ext);
		}
	}
}
