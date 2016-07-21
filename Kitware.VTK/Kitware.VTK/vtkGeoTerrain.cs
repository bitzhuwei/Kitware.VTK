using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoTerrain : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoTerrain";

		public new static readonly string MRClassNameKey;

		static vtkGeoTerrain()
		{
			vtkGeoTerrain.MRClassNameKey = "class vtkGeoTerrain";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoTerrain.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoTerrain"));
		}

		public vtkGeoTerrain(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrain_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoTerrain New()
		{
			vtkGeoTerrain result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTerrain.vtkGeoTerrain_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoTerrain)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoTerrain() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoTerrain.vtkGeoTerrain_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrain_AddActors_01(HandleRef pThis, HandleRef ren, HandleRef assembly, HandleRef imageReps);

		public void AddActors(vtkRenderer ren, vtkAssembly assembly, vtkCollection imageReps)
		{
			vtkGeoTerrain.vtkGeoTerrain_AddActors_01(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (assembly == null) ? default(HandleRef) : assembly.GetCppThis(), (imageReps == null) ? default(HandleRef) : imageReps.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTerrain_GetMaxLevel_02(HandleRef pThis);

		public virtual int GetMaxLevel()
		{
			return vtkGeoTerrain.vtkGeoTerrain_GetMaxLevel_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTerrain_GetMaxLevelMaxValue_03(HandleRef pThis);

		public virtual int GetMaxLevelMaxValue()
		{
			return vtkGeoTerrain.vtkGeoTerrain_GetMaxLevelMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTerrain_GetMaxLevelMinValue_04(HandleRef pThis);

		public virtual int GetMaxLevelMinValue()
		{
			return vtkGeoTerrain.vtkGeoTerrain_GetMaxLevelMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrain_GetOrigin_05(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkGeoTerrain.vtkGeoTerrain_GetOrigin_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrain_GetOrigin_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkGeoTerrain.vtkGeoTerrain_GetOrigin_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrain_GetOrigin_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkGeoTerrain.vtkGeoTerrain_GetOrigin_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrain_GetSource_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGeoSource GetSource()
		{
			vtkGeoSource vtkGeoSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTerrain.vtkGeoTerrain_GetSource_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoSource = (vtkGeoSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoSource.Register(null);
				}
			}
			return vtkGeoSource;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTerrain_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoTerrain.vtkGeoTerrain_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTerrain_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoTerrain.vtkGeoTerrain_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrain_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoTerrain NewInstance()
		{
			vtkGeoTerrain result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTerrain.vtkGeoTerrain_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoTerrain)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrain_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoTerrain SafeDownCast(vtkObjectBase o)
		{
			vtkGeoTerrain vtkGeoTerrain = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTerrain.vtkGeoTerrain_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoTerrain = (vtkGeoTerrain)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoTerrain.Register(null);
				}
			}
			return vtkGeoTerrain;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrain_SaveDatabase_14(HandleRef pThis, string path, int depth);

		public void SaveDatabase(string path, int depth)
		{
			vtkGeoTerrain.vtkGeoTerrain_SaveDatabase_14(base.GetCppThis(), path, depth);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrain_SetMaxLevel_15(HandleRef pThis, int _arg);

		public virtual void SetMaxLevel(int _arg)
		{
			vtkGeoTerrain.vtkGeoTerrain_SetMaxLevel_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrain_SetOrigin_16(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkGeoTerrain.vtkGeoTerrain_SetOrigin_16(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrain_SetOrigin_17(HandleRef pThis, IntPtr _arg);

		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkGeoTerrain.vtkGeoTerrain_SetOrigin_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrain_SetSource_18(HandleRef pThis, HandleRef source);

		public virtual void SetSource(vtkGeoSource source)
		{
			vtkGeoTerrain.vtkGeoTerrain_SetSource_18(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}
	}
}
