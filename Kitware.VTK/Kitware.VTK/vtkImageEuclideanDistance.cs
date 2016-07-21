using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageEuclideanDistance : vtkImageDecomposeFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageEuclideanDistance";

		public new static readonly string MRClassNameKey;

		static vtkImageEuclideanDistance()
		{
			vtkImageEuclideanDistance.MRClassNameKey = "class vtkImageEuclideanDistance";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageEuclideanDistance.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageEuclideanDistance"));
		}

		public vtkImageEuclideanDistance(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageEuclideanDistance_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageEuclideanDistance New()
		{
			vtkImageEuclideanDistance result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageEuclideanDistance.vtkImageEuclideanDistance_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageEuclideanDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageEuclideanDistance() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageEuclideanDistance.vtkImageEuclideanDistance_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEuclideanDistance_ConsiderAnisotropyOff_01(HandleRef pThis);

		public virtual void ConsiderAnisotropyOff()
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_ConsiderAnisotropyOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEuclideanDistance_ConsiderAnisotropyOn_02(HandleRef pThis);

		public virtual void ConsiderAnisotropyOn()
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_ConsiderAnisotropyOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageEuclideanDistance_GetAlgorithm_03(HandleRef pThis);

		public virtual int GetAlgorithm()
		{
			return vtkImageEuclideanDistance.vtkImageEuclideanDistance_GetAlgorithm_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageEuclideanDistance_GetConsiderAnisotropy_04(HandleRef pThis);

		public virtual int GetConsiderAnisotropy()
		{
			return vtkImageEuclideanDistance.vtkImageEuclideanDistance_GetConsiderAnisotropy_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageEuclideanDistance_GetInitialize_05(HandleRef pThis);

		public virtual int GetInitialize()
		{
			return vtkImageEuclideanDistance.vtkImageEuclideanDistance_GetInitialize_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageEuclideanDistance_GetMaximumDistance_06(HandleRef pThis);

		public virtual double GetMaximumDistance()
		{
			return vtkImageEuclideanDistance.vtkImageEuclideanDistance_GetMaximumDistance_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEuclideanDistance_InitializeOff_07(HandleRef pThis);

		public virtual void InitializeOff()
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_InitializeOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEuclideanDistance_InitializeOn_08(HandleRef pThis);

		public virtual void InitializeOn()
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_InitializeOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageEuclideanDistance_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageEuclideanDistance.vtkImageEuclideanDistance_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageEuclideanDistance_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageEuclideanDistance.vtkImageEuclideanDistance_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageEuclideanDistance_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageEuclideanDistance NewInstance()
		{
			vtkImageEuclideanDistance result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageEuclideanDistance.vtkImageEuclideanDistance_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageEuclideanDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageEuclideanDistance_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageEuclideanDistance SafeDownCast(vtkObjectBase o)
		{
			vtkImageEuclideanDistance vtkImageEuclideanDistance = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageEuclideanDistance.vtkImageEuclideanDistance_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageEuclideanDistance = (vtkImageEuclideanDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageEuclideanDistance.Register(null);
				}
			}
			return vtkImageEuclideanDistance;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEuclideanDistance_SetAlgorithm_14(HandleRef pThis, int _arg);

		public virtual void SetAlgorithm(int _arg)
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_SetAlgorithm_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEuclideanDistance_SetAlgorithmToSaito_15(HandleRef pThis);

		public void SetAlgorithmToSaito()
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_SetAlgorithmToSaito_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEuclideanDistance_SetAlgorithmToSaitoCached_16(HandleRef pThis);

		public void SetAlgorithmToSaitoCached()
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_SetAlgorithmToSaitoCached_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEuclideanDistance_SetConsiderAnisotropy_17(HandleRef pThis, int _arg);

		public virtual void SetConsiderAnisotropy(int _arg)
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_SetConsiderAnisotropy_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEuclideanDistance_SetInitialize_18(HandleRef pThis, int _arg);

		public virtual void SetInitialize(int _arg)
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_SetInitialize_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEuclideanDistance_SetMaximumDistance_19(HandleRef pThis, double _arg);

		public virtual void SetMaximumDistance(double _arg)
		{
			vtkImageEuclideanDistance.vtkImageEuclideanDistance_SetMaximumDistance_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageEuclideanDistance_SplitExtent_20(HandleRef pThis, IntPtr splitExt, IntPtr startExt, int num, int total);

		public override int SplitExtent(IntPtr splitExt, IntPtr startExt, int num, int total)
		{
			return vtkImageEuclideanDistance.vtkImageEuclideanDistance_SplitExtent_20(base.GetCppThis(), splitExt, startExt, num, total);
		}
	}
}
