using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageIslandRemoval2D : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageIslandRemoval2D";

		public new static readonly string MRClassNameKey;

		static vtkImageIslandRemoval2D()
		{
			vtkImageIslandRemoval2D.MRClassNameKey = "class vtkImageIslandRemoval2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageIslandRemoval2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageIslandRemoval2D"));
		}

		public vtkImageIslandRemoval2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageIslandRemoval2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageIslandRemoval2D New()
		{
			vtkImageIslandRemoval2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageIslandRemoval2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageIslandRemoval2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageIslandRemoval2D_GetAreaThreshold_01(HandleRef pThis);

		public virtual int GetAreaThreshold()
		{
			return vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_GetAreaThreshold_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageIslandRemoval2D_GetIslandValue_02(HandleRef pThis);

		public virtual double GetIslandValue()
		{
			return vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_GetIslandValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageIslandRemoval2D_GetReplaceValue_03(HandleRef pThis);

		public virtual double GetReplaceValue()
		{
			return vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_GetReplaceValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageIslandRemoval2D_GetSquareNeighborhood_04(HandleRef pThis);

		public virtual int GetSquareNeighborhood()
		{
			return vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_GetSquareNeighborhood_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageIslandRemoval2D_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageIslandRemoval2D_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageIslandRemoval2D_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageIslandRemoval2D NewInstance()
		{
			vtkImageIslandRemoval2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageIslandRemoval2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageIslandRemoval2D_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageIslandRemoval2D SafeDownCast(vtkObjectBase o)
		{
			vtkImageIslandRemoval2D vtkImageIslandRemoval2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageIslandRemoval2D = (vtkImageIslandRemoval2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageIslandRemoval2D.Register(null);
				}
			}
			return vtkImageIslandRemoval2D;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIslandRemoval2D_SetAreaThreshold_10(HandleRef pThis, int _arg);

		public virtual void SetAreaThreshold(int _arg)
		{
			vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_SetAreaThreshold_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIslandRemoval2D_SetIslandValue_11(HandleRef pThis, double _arg);

		public virtual void SetIslandValue(double _arg)
		{
			vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_SetIslandValue_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIslandRemoval2D_SetReplaceValue_12(HandleRef pThis, double _arg);

		public virtual void SetReplaceValue(double _arg)
		{
			vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_SetReplaceValue_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIslandRemoval2D_SetSquareNeighborhood_13(HandleRef pThis, int _arg);

		public virtual void SetSquareNeighborhood(int _arg)
		{
			vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_SetSquareNeighborhood_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIslandRemoval2D_SquareNeighborhoodOff_14(HandleRef pThis);

		public virtual void SquareNeighborhoodOff()
		{
			vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_SquareNeighborhoodOff_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIslandRemoval2D_SquareNeighborhoodOn_15(HandleRef pThis);

		public virtual void SquareNeighborhoodOn()
		{
			vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_SquareNeighborhoodOn_15(base.GetCppThis());
		}
	}
}
